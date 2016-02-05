using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace CSVtoSomethingElse {
    public class Program {
        private static bool jsonSwitch = false;
        private static bool xmlSwitch = false;
        private static bool excelSwitch = false;
        private static string csvInputFile = string.Empty;
        private static string jsonOutputFile = string.Empty;
        private static string xmlOutputFile = string.Empty;
        private static string excelOutputFile = string.Empty;

        public static void Main(string[] args) {
            if (args.Length == 0) {
                Console.WriteLine("No arguments given!");
                Console.WriteLine("Usage: input.csv [-json | -xml | -excel] [output.json | output.xml | output.xlsx]");
                return;
            }
            ParseArgs(args);

            StreamReader stream = null;
            try {
                stream = new StreamReader(csvInputFile);
            } catch (ArgumentException) {
                Console.WriteLine("Input filename not set!");
                return;
            }

            AntlrInputStream antlrStream = new AntlrInputStream(stream.ReadToEnd());
            CSVLexer lexer = new CSVLexer(antlrStream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            CSVParser parser = new CSVParser(tokens);
            IParseTree parseTree = parser.file();

            ParseTreeWalker walker = new ParseTreeWalker();
            LoaderCSV load = new LoaderCSV();

            walker.Walk(load, parseTree);

            if (jsonSwitch) {
                if (jsonOutputFile == string.Empty) {
                    Console.WriteLine("[JSON] Output filename not set!");
                    return;
                }
                SaveToJSON(jsonOutputFile, load);
            }

            if (xmlSwitch) {
                if (xmlOutputFile == string.Empty) {
                    Console.WriteLine("[XML] Output filename not set!");
                    return;
                }
                SaveToXML(xmlOutputFile, load);
            }

            if (excelSwitch) {
                if (excelOutputFile == string.Empty) {
                    Console.WriteLine("[Excel] Output filename not set!");
                    return;
                }
                SaveToExcel(excelOutputFile, load);
            }
        }

        private static void SaveToXML(string outputFilename, LoaderCSV load) {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            using (XmlWriter writer = XmlWriter.Create(outputFilename, settings)) {
                writer.WriteStartDocument();
                writer.WriteStartElement("root");
                foreach (Dictionary<string, string> row in load.Rows) {
                    writer.WriteStartElement("row");
                    foreach (KeyValuePair<string, string> keyValuePair in row) {
                        writer.WriteStartElement(keyValuePair.Key);
                        writer.WriteValue(keyValuePair.Value);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private static void SaveToJSON(string outputFilename, LoaderCSV load) {
            StringBuilder sb = new StringBuilder();

            using (StreamWriter stream = new StreamWriter(outputFilename)) {
                sb.Append("{");
                sb.AppendLine();
                foreach (Dictionary<string, string> row in load.Rows) {
                    int p = 0;
                    sb.Append("\t{");
                    sb.AppendLine();
                    foreach (KeyValuePair<string, string> keyValuePair in row) {
                        string json = "\"" + keyValuePair.Key + "\"" + "=" + "\"" + keyValuePair.Value + "\"";
                        sb.Append("\t\t" + json);
                        if (p != row.Count - 1) {
                            sb.Append(",");
                            sb.AppendLine();
                        }
                        p++;
                    }
                    sb.AppendLine();
                    sb.AppendLine("\t}");
                }
                sb.AppendLine("}");

                stream.Write(sb);
                stream.Close();
            }
        }

        private static void SaveToExcel(string outputFilename, LoaderCSV load) {
            FileInfo file = new FileInfo(outputFilename);
            if (file.Exists) {
                file.Delete();
                file = new FileInfo(outputFilename);
            }

            using (ExcelPackage package = new ExcelPackage(file)) {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("CSVToExcel");
                int i = 2;
                int j = 1;
                foreach (Dictionary<string, string> row in load.Rows) {
                    foreach (KeyValuePair<string, string> keyValuePair in row) {
                        worksheet.Cells[1, j].Value = keyValuePair.Key;
                        worksheet.Cells[i, j].Value = keyValuePair.Value;
                        j++;
                    }
                    j = 1;
                    i++;
                }

                package.Save();
                package.Dispose();
            }
        }

        public static void ParseArgs(string[] arg) {
            for (int i = 0; i < arg.Length; i++) {
                if (arg[i].Contains(".csv")) {
                    csvInputFile = arg[i];
                } else if (arg[i].Contains(".json")) {
                    jsonOutputFile = arg[i];
                } else if (arg[i].Contains(".xml")) {
                    xmlOutputFile = arg[i];
                } else if (arg[i].Contains(".xlsx")) {
                    excelOutputFile = arg[i];
                } else if (arg[i].Contains("-json")) {
                    jsonSwitch = true;
                } else if (arg[i].Contains("-xml")) {
                    xmlSwitch = true;
                } else if (arg[i].Contains("-excel")) {
                    excelSwitch = true;
                } else {
                    Console.WriteLine("Unknown argument: " + arg[i]);
                }
            }
        }
    }
}

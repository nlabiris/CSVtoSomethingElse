using System.Collections.Generic;
using System.Text;

namespace CSVtoSomethingElse {
    public class LoaderCSV : CSVBaseListener {
        private static string EMPTY = string.Empty;
        private List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
        private List<string> header;
        private List<string> currentRowFieldValues;

        public List<Dictionary<string, string>> Rows {
            get { return rows; }
        }

        public override void ExitString(CSVParser.StringContext context) {
            string trimQuote = context.STRING().GetText().TrimStart('\"');
            trimQuote = trimQuote.TrimEnd('\"');

            int first = trimQuote.IndexOf('\"');
            int last = trimQuote.LastIndexOf('\"');
            if (first != -1 || last != -1) {
                trimQuote = trimQuote.Remove(first, 1);
                trimQuote = trimQuote.Remove(last-1, 1);
            }

            currentRowFieldValues.Add(trimQuote);
        }

        public override void ExitText(CSVParser.TextContext context) {
            currentRowFieldValues.Add(context.TEXT().GetText());
        }

        public override void ExitEmpty(CSVParser.EmptyContext context) {
            currentRowFieldValues.Add(EMPTY);
        }

        public override void ExitHdr(CSVParser.HdrContext context) {
            header = new List<string>();
            header.AddRange(currentRowFieldValues);
        }

        public override void EnterRow(CSVParser.RowContext context) {
            currentRowFieldValues = new List<string>();
        }

        public override void ExitRow(CSVParser.RowContext context) {
            if (context.Parent.RuleIndex == CSVParser.RULE_hdr) {
                return;
            }

            Dictionary<string, string> m = new Dictionary<string, string>();
            int i = 0;
            foreach (string v in currentRowFieldValues) {
                m.Add(header[i], v);
                i++;
            }
            rows.Add(m);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            foreach (Dictionary<string, string> row in rows) {
                sb.Append("{");
                foreach (KeyValuePair<string, string> keyValuePair in row) {
                    sb.Append(keyValuePair.Key + "=" + keyValuePair.Value);
                }
                sb.Append("}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}

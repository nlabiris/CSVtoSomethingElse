# CSV to JSON,XML,Excel converter (for now)

A tool to convert a CSV (`.csv`) file into the following formats:

- JSON (`.json`)
- XML (`.xml`)
- Excel (`.xlsx`)

You can use switches in order to get the right output. I used the [ANTLR4 parser generator](https://github.com/antlr/antlr4) in order to create a CSV parser to recognize the input file.

### Usage

```
CSVtoSomethingElse.exe [-json | -xml | -excel] [input.csv] [output.json | output.xml | output.xlsx]
```

#### TODO

- [X] Implement switches
- [X] Provided a binary

#### Source code

You can download the executable below. For the source code, you can click the *"Download ZIP"* on the right or the *"Clone in Desktop"* (if you are using  **Github for Windows**) to clone the repository.

Alternatively, from the command line (if you have `git` installed):
```
git clone https://github.com/nlabiris/ImageEdit_WPF.git
```

#### Download binary

[CSVToSomethingElse v0.1 beta](https://github.com/nlabiris/CSVtoSomethingElse/blob/master/CSVtoSomethingElse/bin/Release/CSVtoSomethingElse_v0.1_beta.rar?raw=true)

#### License

The software is licensed under the `GNU GENERAL PUBLIC LICENSE Version 3`. For more information check the `LICENSE` file.

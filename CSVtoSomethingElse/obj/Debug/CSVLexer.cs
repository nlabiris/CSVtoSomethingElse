//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\Sonic\Documents\Visual Studio 2013\Projects\CSVtoSomethingElse\CSVtoSomethingElse\CSV.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CSVtoSomethingElse {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class CSVLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, TEXT=4, STRING=5, WS=6;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "TEXT", "STRING", "WS"
	};


	public CSVLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", "'\r'", "'\n'", null, null, "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "TEXT", "STRING", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CSV.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\b)\b\x1\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x3\x2\x3\x2\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x5\x6\x5\x17\n\x5\r\x5\xE\x5\x18\x3\x6\x3\x6"+
		"\x3\x6\x3\x6\a\x6\x1F\n\x6\f\x6\xE\x6\"\v\x6\x3\x6\x3\x6\x3\a\x3\a\x3"+
		"\a\x3\a\x2\x2\x2\b\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\x3"+
		"\x2\x4\x6\x2\f\f\xF\xF$$..\x3\x2$$+\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2"+
		"\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x3"+
		"\xF\x3\x2\x2\x2\x5\x11\x3\x2\x2\x2\a\x13\x3\x2\x2\x2\t\x16\x3\x2\x2\x2"+
		"\v\x1A\x3\x2\x2\x2\r%\x3\x2\x2\x2\xF\x10\a.\x2\x2\x10\x4\x3\x2\x2\x2\x11"+
		"\x12\a\xF\x2\x2\x12\x6\x3\x2\x2\x2\x13\x14\a\f\x2\x2\x14\b\x3\x2\x2\x2"+
		"\x15\x17\n\x2\x2\x2\x16\x15\x3\x2\x2\x2\x17\x18\x3\x2\x2\x2\x18\x16\x3"+
		"\x2\x2\x2\x18\x19\x3\x2\x2\x2\x19\n\x3\x2\x2\x2\x1A \a$\x2\x2\x1B\x1C"+
		"\a$\x2\x2\x1C\x1F\a$\x2\x2\x1D\x1F\n\x3\x2\x2\x1E\x1B\x3\x2\x2\x2\x1E"+
		"\x1D\x3\x2\x2\x2\x1F\"\x3\x2\x2\x2 \x1E\x3\x2\x2\x2 !\x3\x2\x2\x2!#\x3"+
		"\x2\x2\x2\" \x3\x2\x2\x2#$\a$\x2\x2$\f\x3\x2\x2\x2%&\a\"\x2\x2&\'\x3\x2"+
		"\x2\x2\'(\b\a\x2\x2(\xE\x3\x2\x2\x2\x6\x2\x18\x1E \x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace CSVtoSomethingElse

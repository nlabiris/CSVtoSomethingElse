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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class CSVParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, TEXT=4, STRING=5, WS=6;
	public const int
		RULE_file = 0, RULE_hdr = 1, RULE_row = 2, RULE_field = 3;
	public static readonly string[] ruleNames = {
		"file", "hdr", "row", "field"
	};

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

	public override string SerializedAtn { get { return _serializedATN; } }

	public CSVParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class FileContext : ParserRuleContext {
		public HdrContext hdr() {
			return GetRuleContext<HdrContext>(0);
		}
		public RowContext[] row() {
			return GetRuleContexts<RowContext>();
		}
		public RowContext row(int i) {
			return GetRuleContext<RowContext>(i);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterFile(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitFile(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICSVVisitor<TResult> typedVisitor = visitor as ICSVVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 8; hdr();
			State = 10;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 9; row();
				}
				}
				State = 12;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << TEXT) | (1L << STRING))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HdrContext : ParserRuleContext {
		public RowContext row() {
			return GetRuleContext<RowContext>(0);
		}
		public HdrContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_hdr; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterHdr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitHdr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICSVVisitor<TResult> typedVisitor = visitor as ICSVVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHdr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HdrContext hdr() {
		HdrContext _localctx = new HdrContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_hdr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; row();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RowContext : ParserRuleContext {
		public FieldContext[] field() {
			return GetRuleContexts<FieldContext>();
		}
		public FieldContext field(int i) {
			return GetRuleContext<FieldContext>(i);
		}
		public RowContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_row; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterRow(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitRow(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICSVVisitor<TResult> typedVisitor = visitor as ICSVVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRow(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RowContext row() {
		RowContext _localctx = new RowContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_row);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16; field();
			State = 21;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__0) {
				{
				{
				State = 17; Match(T__0);
				State = 18; field();
				}
				}
				State = 23;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 25;
			_la = _input.La(1);
			if (_la==T__1) {
				{
				State = 24; Match(T__1);
				}
			}

			State = 27; Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FieldContext : ParserRuleContext {
		public FieldContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_field; } }
	 
		public FieldContext() { }
		public virtual void CopyFrom(FieldContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class StringContext : FieldContext {
		public ITerminalNode STRING() { return GetToken(CSVParser.STRING, 0); }
		public StringContext(FieldContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICSVVisitor<TResult> typedVisitor = visitor as ICSVVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TextContext : FieldContext {
		public ITerminalNode TEXT() { return GetToken(CSVParser.TEXT, 0); }
		public TextContext(FieldContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitText(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICSVVisitor<TResult> typedVisitor = visitor as ICSVVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitText(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class EmptyContext : FieldContext {
		public EmptyContext(FieldContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterEmpty(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitEmpty(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICSVVisitor<TResult> typedVisitor = visitor as ICSVVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEmpty(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FieldContext field() {
		FieldContext _localctx = new FieldContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_field);
		try {
			State = 32;
			switch (_input.La(1)) {
			case TEXT:
				_localctx = new TextContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 29; Match(TEXT);
				}
				break;
			case STRING:
				_localctx = new StringContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 30; Match(STRING);
				}
				break;
			case T__0:
			case T__1:
			case T__2:
				_localctx = new EmptyContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\b%\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x3\x2\x3\x2\x6\x2\r\n\x2\r\x2\xE\x2\xE"+
		"\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\a\x4\x16\n\x4\f\x4\xE\x4\x19\v\x4\x3\x4"+
		"\x5\x4\x1C\n\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x5\x5#\n\x5\x3\x5\x2\x2"+
		"\x2\x6\x2\x2\x4\x2\x6\x2\b\x2\x2\x2%\x2\n\x3\x2\x2\x2\x4\x10\x3\x2\x2"+
		"\x2\x6\x12\x3\x2\x2\x2\b\"\x3\x2\x2\x2\n\f\x5\x4\x3\x2\v\r\x5\x6\x4\x2"+
		"\f\v\x3\x2\x2\x2\r\xE\x3\x2\x2\x2\xE\f\x3\x2\x2\x2\xE\xF\x3\x2\x2\x2\xF"+
		"\x3\x3\x2\x2\x2\x10\x11\x5\x6\x4\x2\x11\x5\x3\x2\x2\x2\x12\x17\x5\b\x5"+
		"\x2\x13\x14\a\x3\x2\x2\x14\x16\x5\b\x5\x2\x15\x13\x3\x2\x2\x2\x16\x19"+
		"\x3\x2\x2\x2\x17\x15\x3\x2\x2\x2\x17\x18\x3\x2\x2\x2\x18\x1B\x3\x2\x2"+
		"\x2\x19\x17\x3\x2\x2\x2\x1A\x1C\a\x4\x2\x2\x1B\x1A\x3\x2\x2\x2\x1B\x1C"+
		"\x3\x2\x2\x2\x1C\x1D\x3\x2\x2\x2\x1D\x1E\a\x5\x2\x2\x1E\a\x3\x2\x2\x2"+
		"\x1F#\a\x6\x2\x2 #\a\a\x2\x2!#\x3\x2\x2\x2\"\x1F\x3\x2\x2\x2\" \x3\x2"+
		"\x2\x2\"!\x3\x2\x2\x2#\t\x3\x2\x2\x2\x6\xE\x17\x1B\"";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace CSVtoSomethingElse

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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CSVParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface ICSVListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] CSVParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] CSVParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>text</c>
	/// labeled alternative in <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] CSVParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>text</c>
	/// labeled alternative in <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] CSVParser.TextContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>empty</c>
	/// labeled alternative in <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty([NotNull] CSVParser.EmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>empty</c>
	/// labeled alternative in <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty([NotNull] CSVParser.EmptyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] CSVParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] CSVParser.FileContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.hdr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHdr([NotNull] CSVParser.HdrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.hdr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHdr([NotNull] CSVParser.HdrContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow([NotNull] CSVParser.RowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow([NotNull] CSVParser.RowContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField([NotNull] CSVParser.FieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField([NotNull] CSVParser.FieldContext context);
}
} // namespace CSVtoSomethingElse

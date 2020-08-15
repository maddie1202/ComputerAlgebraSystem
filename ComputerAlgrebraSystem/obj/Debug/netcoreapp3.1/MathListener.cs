//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\madel\source\repos\ComputerAlgebraSystem\ComputerAlgrebraSystem\Grammar\Math.g4 by ANTLR 4.6.6-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ComputerAlgrebraSystem.Grammar {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IMathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivision([NotNull] MathParser.DivisionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivision([NotNull] MathParser.DivisionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentheses([NotNull] MathParser.ParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentheses([NotNull] MathParser.ParenthesesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] MathParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] MathParser.NumberContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>function</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] MathParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>function</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] MathParser.FunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] MathParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] MathParser.VariableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtraction([NotNull] MathParser.SubtractionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtraction([NotNull] MathParser.SubtractionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationNoAsterisk</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationNoAsterisk([NotNull] MathParser.MultiplicationNoAsteriskContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationNoAsterisk</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationNoAsterisk([NotNull] MathParser.MultiplicationNoAsteriskContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>unary</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary([NotNull] MathParser.UnaryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unary</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary([NotNull] MathParser.UnaryContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>power</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPower([NotNull] MathParser.PowerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>power</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPower([NotNull] MathParser.PowerContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplication([NotNull] MathParser.MultiplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplication([NotNull] MathParser.MultiplicationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddition([NotNull] MathParser.AdditionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddition([NotNull] MathParser.AdditionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>equationCompileUnit</c>
	/// labeled alternative in <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquationCompileUnit([NotNull] MathParser.EquationCompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equationCompileUnit</c>
	/// labeled alternative in <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquationCompileUnit([NotNull] MathParser.EquationCompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>expressionCompileUnit</c>
	/// labeled alternative in <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionCompileUnit([NotNull] MathParser.ExpressionCompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionCompileUnit</c>
	/// labeled alternative in <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionCompileUnit([NotNull] MathParser.ExpressionCompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>doubleParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoubleParentheses([NotNull] MathParser.DoubleParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>doubleParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoubleParentheses([NotNull] MathParser.DoubleParenthesesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>variableNumber</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableNumber([NotNull] MathParser.VariableNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variableNumber</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableNumber([NotNull] MathParser.VariableNumberContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>numberVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberVariable([NotNull] MathParser.NumberVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberVariable([NotNull] MathParser.NumberVariableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationParentheses([NotNull] MathParser.MultiplicationParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationParentheses([NotNull] MathParser.MultiplicationParenthesesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesesMultiplication</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesesMultiplication([NotNull] MathParser.ParenthesesMultiplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesesMultiplication</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesesMultiplication([NotNull] MathParser.ParenthesesMultiplicationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>variableParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableParentheses([NotNull] MathParser.VariableParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variableParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableParentheses([NotNull] MathParser.VariableParenthesesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationVariable([NotNull] MathParser.MultiplicationVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationVariable([NotNull] MathParser.MultiplicationVariableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesesNumber</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesesNumber([NotNull] MathParser.ParenthesesNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesesNumber</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesesNumber([NotNull] MathParser.ParenthesesNumberContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesesVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesesVariable([NotNull] MathParser.ParenthesesVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesesVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesesVariable([NotNull] MathParser.ParenthesesVariableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>variableMultiplication</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableMultiplication([NotNull] MathParser.VariableMultiplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variableMultiplication</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableMultiplication([NotNull] MathParser.VariableMultiplicationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>numberParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberParentheses([NotNull] MathParser.NumberParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberParentheses</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberParentheses([NotNull] MathParser.NumberParenthesesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>variableVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableVariable([NotNull] MathParser.VariableVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variableVariable</c>
	/// labeled alternative in <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableVariable([NotNull] MathParser.VariableVariableContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] MathParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] MathParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquation([NotNull] MathParser.EquationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquation([NotNull] MathParser.EquationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MathParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MathParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionName([NotNull] MathParser.FunctionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionName([NotNull] MathParser.FunctionNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.parenthesesExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesesExpression([NotNull] MathParser.ParenthesesExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.parenthesesExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesesExpression([NotNull] MathParser.ParenthesesExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationExpression([NotNull] MathParser.MultiplicationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationExpression([NotNull] MathParser.MultiplicationExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.numberExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpression([NotNull] MathParser.NumberExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.numberExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpression([NotNull] MathParser.NumberExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.variableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableExpression([NotNull] MathParser.VariableExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.variableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableExpression([NotNull] MathParser.VariableExpressionContext context);
}
} // namespace ComputerAlgrebraSystem.Grammar

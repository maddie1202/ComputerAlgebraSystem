namespace ComputerAlgrebraSystem.Model
{
    public abstract class SymbolicFunction
    {
        public abstract string FucntionText { get; }
        public Expression Argument { get; set; }

        public override string ToString()
        {
            return FucntionText + "(" + Argument.ToString() + ")";
        }
    }

    public class SquareRootFunction : SymbolicFunction
    {
        public override string FucntionText => "sqrt";
    }

    public class ExponentialFunction : SymbolicFunction
    {
        public override string FucntionText => "exp";
    }
}
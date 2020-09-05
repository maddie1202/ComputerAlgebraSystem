namespace ComputerAlgrebraSystem.Model
{
    public abstract class SymbolicFunction : Multiplier
    {
        public abstract string FucntionText { get; }
        public Expression Argument { get; set; }

        public RationalNumber Degree => 1;

        public Multiplier Reciprocal()
        {
            throw new System.NotImplementedException();
        }

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
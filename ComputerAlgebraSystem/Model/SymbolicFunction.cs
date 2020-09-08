using ComputerAlgebraSystem.Model;

namespace ComputerAlgrebraSystem.Model
{
    public abstract class SymbolicFunction : IMultiplier
    {
        public abstract string FucntionText { get; }
        public Expression Argument { get; set; }

        public RationalNumber Degree => 1;

        public IMultiplier Reciprocal()
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
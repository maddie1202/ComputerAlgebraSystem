namespace ComputerAlgrebraSystem.Model
{
    public class PowerOperation : Multiplier
    {
        public Expression Base { get; set; }
        public Expression Exponent { get; set; }

        public RationalNumber Degree => 1;

        public override string ToString()
        {
            var exponent = Exponent.ToString();

            if (!double.TryParse(exponent, out _) && exponent.Length > 1)
            {
                exponent = "(" + exponent + ")";
            }

            return Base.ToString() + "^" + exponent;
        }
    }
}
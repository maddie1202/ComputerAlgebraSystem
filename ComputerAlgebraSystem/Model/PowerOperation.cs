namespace ComputerAlgrebraSystem.Model
{
    public class PowerOperation
    {
        public Expression Base { get; set; }
        public Expression Exponent { get; set; }

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
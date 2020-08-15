using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;

namespace ComputerAlgrebraSystem.Model
{
    public class Variable
    {
        public char Symbol { get; set; }
        public Constant Degree { get; set; } = 1;

        public override string ToString() => Symbol.ToString();
    }
}
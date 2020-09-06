using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgrebraSystem.Utils
{
    public static class MathUtils
    {
        public static int LeastCommonMultiple(int int1, int int2)
        {
            return int1 * int2 / GreatestCommonFactor(int1, int2);
        }

        public static int GreatestCommonFactor(int int1, int int2)
        {
            if (int1 == 0) { return int2; }
            if (int2 == 0) { return int1; }

            var remainder = int1 % int2;

            return GreatestCommonFactor(int2, remainder);
        }
    }
}

﻿using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;

namespace ComputerAlgrebraSystem.Model
{
    public class Variable : Multiplier
    {
        public char Symbol { get; set; }
        public RationalNumber Degree { get; set; } = 1;

        public Multiplier Reciprocal()
        {
            return new Variable { Symbol = Symbol, Degree = Degree.Number * -1 };
        }

        public override string ToString() => Symbol.ToString();
    }
}
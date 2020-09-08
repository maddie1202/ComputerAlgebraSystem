using ComputerAlgrebraSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgebraSystem.Model
{
    public interface IMultiplier
    {
        RationalNumber Degree { get; }
        IMultiplier Reciprocal();
    }
}

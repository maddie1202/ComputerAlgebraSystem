using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerAlgebraSystem.Model
{
    public interface IComponent
    {
        IComponent Add(IComponent other);
        IComponent Subtract(IComponent other);
        IComponent Multiply(IComponent other);
        IComponent Divide(IComponent other);
        IComponent Reciprocal();
    }
}

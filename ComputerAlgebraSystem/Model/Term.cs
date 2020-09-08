using ComputerAlgebraSystem.Model;
using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ComputerAlgrebraSystem.Model
{
    public class Term : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public IEnumerable<IComponent> Components => components.AsEnumerable();

        public Term() { }

        public Term(params IComponent[] components) : this((IEnumerable<IComponent>)components) { }

        public Term(IEnumerable<IComponent> components)
        {
            this.components.AddRange(components);
        }

        public IComponent Add(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Divide(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Multiply(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Subtract(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Reciprocal()
        {
            throw new NotImplementedException();
        }
    }
}

using ComputerAlgebraSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ComputerAlgrebraSystem.Model
{
    public class Expression : IComponent
    {
        private List<IComponent> components = new List<IComponent>();
        public IEnumerable<IComponent> Components => components.AsEnumerable();

        public Expression()
        {
        }

        public Expression(params IComponent[] components) : this((IEnumerable<IComponent>)components)
        {
        }

        public Expression(IEnumerable<IComponent> components)
        {
            this.components = components.ToList();
        }

        public Expression DeepCopy()
        {
            return new Expression(new List<IComponent>(components));
        }

        public IComponent Add(IComponent other)
        {
            var newExpression = DeepCopy();
            newExpression.components.Add(other);
            return newExpression;
        }

        public IComponent Subtract(IComponent other)
        {
            var newExpression = DeepCopy();
            //newExpression.components.Add(other.Multiply(-1));
            return newExpression;
        }

        public IComponent Multiply(IComponent other)
        {
            return new Expression(new Term(this, other));
        }

        public IComponent Divide(IComponent other)
        {
            return new Expression(new Term(this, other.Reciprocal()));
        }

        public IComponent Reciprocal()
        {
            throw new NotImplementedException();
        }
    }
}

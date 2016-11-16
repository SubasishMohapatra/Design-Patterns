using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PizzaDecorator : IDecorator
    {
        private IDecorator decorator;

        public PizzaDecorator(IDecorator decorator)
        {
            this.decorator = decorator;
        }

        public string Name
        {
            get
            {
                return "Pizza";
            }
        }

        public string Display()
        {
            return this.decorator.Name + " " + this.Name;
        }
    }
}

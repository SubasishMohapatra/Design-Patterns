using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheeseDecorator : IDecorator
    {
        private IDecorator decorator;

        public CheeseDecorator(IDecorator decorator)
        {
            this.decorator = decorator;
        }

        public string Name
        {
            get
            {
                return "Cheese";
            }
        }

        public string Display()
        {
            return this.decorator != null ? this.decorator.Name + " " : "" + this.Name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

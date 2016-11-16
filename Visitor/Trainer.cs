using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Trainer
    {
        public Trainer(string name) { this.Name = name; }

        protected string Name { get; set; }
        public abstract void Visit(Employee emp);
    }
}

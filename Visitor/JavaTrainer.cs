using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class JavaTrainer : Trainer
    {
        public JavaTrainer(string name) : base(name)
        {
        }

        public override void Visit(Employee emp)
        {
            Console.WriteLine("{0} trained in java by {1}", emp.Name, this.Name);
        }
    }
}

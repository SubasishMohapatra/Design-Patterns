using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class Developer : Role
    {
        public override void DoJob(Project project)
        {
            Console.WriteLine("Write code");
            base.DoJob(project);
        }
    }
}

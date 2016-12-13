using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class Tester : Role
    {
        public override void DoJob(Project project)
        {
            Console.WriteLine("Test App");
            base.DoJob(project);
        }
    }
}

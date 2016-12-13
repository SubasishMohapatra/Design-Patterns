using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public abstract class Role
    {
        public virtual void DoJob(Project project)
        {
            if (Sucessor != null)
                Sucessor.DoJob(project);
        }

        public Role Sucessor { get; set; }
    }
}

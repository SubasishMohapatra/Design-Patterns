using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HR : BaseInterview
    {
        public override bool IsCleared(Candidate candidate)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Interview
    {
        IInterview technical = new Technical();
        IInterview managerial = new Managerial();
        IInterview hr = new HR();
        Candidate candidate;

        public void ScreenCandidate(Candidate candidate)
        {
            this.candidate = candidate;
        }

        public bool IsCleared
        {
            get
            {
                return technical.IsCleared(candidate) && technical.IsCleared(candidate) && technical.IsCleared(candidate);
            }
        }
    }
}

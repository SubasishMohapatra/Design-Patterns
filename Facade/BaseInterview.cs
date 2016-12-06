using System;

namespace Facade
{
    public class BaseInterview : IInterview
    {
        public virtual bool IsCleared (Candidate candidate)
        {
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ReadOnlyState:IState
    {
        public ReadOnlyState()
        {
            
        }

        public bool CanSubmit(SomeObject someObject)
        {
            return false;
        }

        public void Submit(SomeObject someObject)
        {
            Console.WriteLine("Cant save a read-only object");
        }
    }
}

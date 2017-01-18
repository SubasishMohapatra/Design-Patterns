using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NewState:IState
    {
        public NewState()
        {            
        }

        public bool CanSubmit(SomeObject someObject)
        {
            return true;
        }

        public void Submit(SomeObject someObject)
        {
            //Validations
            Console.WriteLine("New object created");
            someObject.ChangeState(new EditState());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class EditState : IState
    {
        public EditState()
        {
            
        }

        public bool CanSubmit(SomeObject someObject)
        {
            return true;
        }

        public void Submit(SomeObject someObject)
        {
            //Validations like ID not changeable
            Console.WriteLine("Saved changes");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SomeObject
    {
        IState state;

        public SomeObject()
        {
            this.state = new NewState();
        }

        public void Submit()
        {
            this.state.Submit(this);
        }

        public void ChangeState(IState state)
        {
            this.state = state;
        }
      
    }
}

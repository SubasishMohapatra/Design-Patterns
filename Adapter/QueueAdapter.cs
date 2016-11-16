using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class QueueAdapter : Queue<string>, IAdapter
    {
        public string Pop()
        {
            return base.Dequeue(); 
        }

        public void Push(string item)
        {
            base.Enqueue(item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subscriber
    {
        Observer observer;
        string name;
        public Subscriber(string name,Observer o)
        {
            this.observer = o;
            this.name = name;
        }

        public void Subscribe(int publisherID)
        {
            observer.Register(publisherID, () => Console.WriteLine(string.Format("Publisher {0} updated in {1}",publisherID,name)));
        }
    }
}

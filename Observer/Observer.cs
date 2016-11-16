using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer
    {
        Dictionary<int, Action> subscribers = new Dictionary<int, Action>();

        public void Register(int publisherID, Action callback)
        {
            if (!subscribers.ContainsKey(publisherID))
                subscribers.Add(publisherID, callback);
            else
                subscribers[publisherID] += callback;
        }

        public void Unregister(int publisherID)
        {
            if (subscribers.ContainsKey(publisherID))
                subscribers.Remove(publisherID);
        }

        public void Notify(Publisher publisher)
        {
            if (subscribers.ContainsKey(publisher.ID))
            {
                subscribers[publisher.ID]();
            }
        }
    }
}

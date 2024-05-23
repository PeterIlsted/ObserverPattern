using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public abstract class Subject
    {
        List<Observer> observers = new List<Observer>();
        public void Attach(Observer o) { observers.Add(o); }
        public void Detach(Observer observer) { observers.Remove(observer); }
        public void Notify()
        {
            foreach (Observer o in observers)
                o.Update();
            
        }
    }
}

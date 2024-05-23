using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject = new ConcreteSubject();
		private int _state;

		public int State
		{
			get { return _state; }
			set { _state = value; }
		}
		public ConcreteObserver(ConcreteSubject subject)
		{
			this.subject = subject;
		}
		public override void Update()
		{
			_state = subject.State;
		}
	}
}

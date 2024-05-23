using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem_Interface
{
    public class Academy : Organisation, ISubject 
    {
        private List<IObserver> students = new List<IObserver>();
		private string _message;

		public string Message
		{
			get { return _message; }
			set 
			{ 
				_message = value;
				Notify();
			}
		}
		public Academy(string name, string adress) : base(name)
		{
			base.Adress = adress;
		}
		public void Attach(IObserver o)
		{
			students.Add(o);
		}
		public void Detach(IObserver o)
		{
			students.Remove(o);
		}
		public void Notify()
		{
			foreach (var student in students)
			{
				student.Update();
			}
		}
	}
}

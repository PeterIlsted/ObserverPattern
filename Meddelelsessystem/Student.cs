using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public class Student : Person
    {
        private Academy subject;
		private string _message;

		public string Message
		{
			get { return _message; }
			set { _message = value; }
		}
		private string _name;

		public string Name { get { return _name; } }

		public Student(Academy subject, string name) : base(name)
		{
			this.subject = subject;
			this._name = name;
		}
		public override void Update()
		{
			_message = subject.Message;
			Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {subject.Name}");
		}
	}
}

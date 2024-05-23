using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem_Interface
{
    public class Student : Person, IObserver
    {
        private Academy academy;
		private string _message;

		public string Message
		{
			get { return _message; }
			set { _message = value; }
		}

        private string _name;

        public string Name { get { return _name; } }
        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
            this._name = name;
        }
        public void Update()
        {
            _message = academy.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {academy.Name}");
        }
    }
}

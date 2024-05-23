using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public class Academy : Organisation
    {
		private string _name;

		public string Name
		{
			get { return _name; }
		}

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
        public Academy(string name, string message) : base(name)
        {
			_name = name;
			_message = message;
        }
		public Academy(string name) : base(name) 
		{
			_name = name;
		}
    }
}

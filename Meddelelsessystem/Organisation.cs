using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public class Organisation : Subject
    {
		private string _name;

		public string Name
		{
			get { return _name; }
		}
		private string _adress = null;

		public string Adress
		{
			get { return _adress; }
			set { _adress = value; }
		}
		public Organisation(string name) { _name = name; }

	}
}

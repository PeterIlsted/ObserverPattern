using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem_Interface
{
    public class Organisation(string name)
    {
		private string _name = name;

		public string Name
		{
			get { return _name; }
		}
		private string _adress;

		public string Adress
		{
			get { return _adress; }
			set { _adress = value; }
		}
    }
}

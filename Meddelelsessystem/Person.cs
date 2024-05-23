using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public class Person : Observer
    {
        private string _name;

        public string Name { get { return _name; } }
        public Person(string name)
        {
            _name = name;
        }
        public override void Update()
        {
        }
    }
}

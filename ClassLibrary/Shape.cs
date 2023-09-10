using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Shape
    {
        public string name { get { return name; } set { name = value; } }
        public abstract void Accept( Visitor visitor );
        public Shape(string value)
        {
            name = value;
        }

    }
}

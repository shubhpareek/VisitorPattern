using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Shape
    {
        public string name { get; set; }
        public string type;
        public abstract void Accept( Visitor visitor );
        public Shape(string value,string typeName)
        {
            name = value;
            type = typeName;
        }

    }
}

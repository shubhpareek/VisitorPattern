using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Type;
        public abstract void Accept( Visitor visitor );
        public Shape(string value,string typeName)
        {
            Name = value;
            Type = typeName;
        }

    }
}

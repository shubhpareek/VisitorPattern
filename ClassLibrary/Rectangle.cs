using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Shape
    {
        public double Length;
        public double Breadth;

        public Rectangle(double l, double b,string value,string typeName):base(value,typeName)
        {
            Breadth = b;
            Length  =  l;
        }
        public override void Accept( Visitor visitor )
        {
            visitor.VisitRectangle( this );
        }
    }
}

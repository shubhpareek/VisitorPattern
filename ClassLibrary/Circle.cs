using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle : Shape
    {
        public double Radius;
        public Circle(double radius,string value,string typeName):base(value,typeName)
        { Radius = radius; }   

        public override void Accept( Visitor visitor )
        {
            visitor.VisitCircle( this );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle : Shape
    {
        public double radius;
        public Circle(double radius,string value,string typeName):base(value,typeName)
        { this.radius = radius; }   
        public override void Accept( Visitor visitor )
        {
            visitor.VisitCircle( this );
        }
    }
}

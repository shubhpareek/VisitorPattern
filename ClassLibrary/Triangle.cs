using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle : Shape
    {
        public double side1;
        public double side2;
        public double side3;
        public Triangle( double s1 , double s2 , double s3 ,string value,string typeName) : base(value,typeName)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public override void Accept( Visitor visitor )
        {
            visitor.VisitTriangle( this );
        }

    }
}

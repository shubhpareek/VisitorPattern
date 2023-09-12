using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle : Shape
    {
        public double Side1;
        public double Side2;
        public double Side3;
        public Triangle( double s1 , double s2 , double s3 ,string value,string typeName) : base(value,typeName)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }
        public override void Accept( Visitor visitor )
        {
            visitor.VisitTriangle( this );
        }

    }
}

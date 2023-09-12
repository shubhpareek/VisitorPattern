using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AreaVisitor: Visitor
    {
        public override void VisitCircle(Circle obj)
        {
            Console.WriteLine( "Area of Circle {0} is {1}" , obj.Name , Math.PI * obj.Radius * obj.Radius );
        }
        public override void VisitRectangle(Rectangle obj)
        {
            Console.WriteLine( "Area of Rectangle {0} is {1} " , obj.Name , obj.Length * obj.Breadth );
        }
        public override void VisitTriangle(Triangle obj ) 
        {
            // Calculate the semi-perimeter of the triangle
            double semiPerimeter = (obj.Side1 + obj.Side2 + obj.Side3) / 2.0;

            // Calculate the area using Heron's formula
            double area = Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - obj.Side1) *
                (semiPerimeter - obj.Side2) *
                (semiPerimeter - obj.Side3)
            );

            Console.WriteLine( "Area of Triangle {0} is {1}" , obj.Name , area );
        } 

    }
}

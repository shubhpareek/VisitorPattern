using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PerimeterVisitor: Visitor
    {
        
        public override void VisitCircle(Circle obj)
        {
            Console.WriteLine( "Area of Circle {0} is {1}" , obj.name , Math.PI * obj.radius * obj.radius );
        }
        public override void VisitRectangle(Rectangle obj)
        {
            Console.WriteLine( "Area of Rectangle {0} is {1} " , obj.name , obj.length * obj.breadth );
        }
        public override void VisitTriangle(Triangle obj ) 
        {
            // Calculate the semi-perimeter of the triangle
            double semiPerimeter = (obj.side1 + obj.side2 + obj.side3) / 2.0;

            // Calculate the area using Heron's formula
            double area = Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - obj.side1) *
                (semiPerimeter - obj.side2) *
                (semiPerimeter - obj.side3)
            );

            Console.WriteLine( "Area of Triangle {0} is {1}" , obj.name , area );
        } 
    }
}

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
            Console.WriteLine( "Perimeter of Circle {0} is {1}" , obj.name , 2 * Math.PI * obj.radius );
        }
        public override void VisitRectangle(Rectangle obj)
        {
            Console.WriteLine( "Perimeter of Rectangle {0} is {1} " , obj.name , 2*(obj.length + obj.breadth ));
        }
        public override void VisitTriangle(Triangle obj ) 
        {
            Console.WriteLine( "Perimeter of Triangle {0} is {1}" , obj.name , (obj.side1 + obj.side2 + obj.side3));
        } 
    }
}

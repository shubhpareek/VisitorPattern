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
            Console.WriteLine( "Perimeter of Circle {0} is {1}" , obj.Name , 2 * Math.PI * obj.Radius );
        }
        public override void VisitRectangle(Rectangle obj)
        {
            Console.WriteLine( "Perimeter of Rectangle {0} is {1} " , obj.Name , 2*(obj.Length + obj.Breadth ));
        }
        public override void VisitTriangle(Triangle obj ) 
        {
            Console.WriteLine( "Perimeter of Triangle {0} is {1}" , obj.Name , (obj.Side1 + obj.Side2 + obj.Side3));
        } 
    }
}

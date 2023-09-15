using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Concrete visitor class to calculate and display the perimeter of different shapes.
    /// </summary>
    public class PerimeterVisitor : Visitor
    {
        /// <summary>
        /// Visits a Circle object and calculates its perimeter.
        /// </summary>
        /// <param name="obj">The Circle object to visit.</param>
        public override void VisitCircle( Circle obj )
        {
            Console.WriteLine( "Perimeter of Circle {0} is {1}" , obj.Name , 2 * Math.PI * obj.Radius );
        }

        /// <summary>
        /// Visits a Rectangle object and calculates its perimeter.
        /// </summary>
        /// <param name="obj">The Rectangle object to visit.</param>
        public override void VisitRectangle( Rectangle obj )
        {
            Console.WriteLine( "Perimeter of Rectangle {0} is {1}" , obj.Name , 2 * (obj.Length + obj.Breadth) );
        }

        /// <summary>
        /// Visits a Triangle object and calculates its perimeter.
        /// </summary>
        /// <param name="obj">The Triangle object to visit.</param>
        public override void VisitTriangle( Triangle obj )
        {
            Console.WriteLine( "Perimeter of Triangle {0} is {1}" , obj.Name , (obj.Side1 + obj.Side2 + obj.Side3) );
        }
    }

}

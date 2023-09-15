using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    ///<summary>
    ///visitor for calculating area of shape objects 
    ///</summary>
    /// <summary>
    /// Concrete visitor class to calculate and display the area of different shapes.
    /// </summary>
    public class AreaVisitor : Visitor
    {
        /// <summary>
        /// Visits a Circle object and calculates its area.
        /// </summary>
        /// <param name="obj">The Circle object to visit.</param>
        public override void VisitCircle( Circle obj )
        {
            Console.WriteLine( "Area of Circle {0} is {1}" , obj.Name , Math.PI * obj.Radius * obj.Radius );
        }

        /// <summary>
        /// Visits a Rectangle object and calculates its area.
        /// </summary>
        /// <param name="obj">The Rectangle object to visit.</param>
        public override void VisitRectangle( Rectangle obj )
        {
            Console.WriteLine( "Area of Rectangle {0} is {1}" , obj.Name , obj.Length * obj.Breadth );
        }

        /// <summary>
        /// Visits a Triangle object and calculates its area using Heron's formula.
        /// </summary>
        /// <param name="obj">The Triangle object to visit.</param>
        public override void VisitTriangle( Triangle obj )
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

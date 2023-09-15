using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Represents a circle shape with a specified radius.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Gets or sets the radius of the circle.
        /// </summary>
        public double Radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with a specified radius, value, and type name.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <param name="value">The name associated with the circle.</param>
        /// <param name="typeName">The type name of the circle.</param>
        public Circle( double radius , string value , string typeName ) : base( value , typeName )
        {
            Radius = radius;
        }

        /// <summary>
        /// Accepts a visitor and calls the appropriate method for visiting a circle.
        /// </summary>
        /// <param name="visitor">The visitor object used to visit this circle.</param>
        public override void Accept( Visitor visitor )
        {
            visitor.VisitCircle( this );
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Represents a rectangle shape with specified length and breadth.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Gets or sets the length of the rectangle.
        /// </summary>
        public double Length;

        /// <summary>
        /// Gets or sets the breadth of the rectangle.
        /// </summary>
        public double Breadth;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class with specified length, breadth, value, and type name.
        /// </summary>
        /// <param name="l">The length of the rectangle.</param>
        /// <param name="b">The breadth of the rectangle.</param>
        /// <param name="value">The value associated with the rectangle.</param>
        /// <param name="typeName">The type name of the rectangle.</param>
        public Rectangle( double l , double b , string value , string typeName ) : base( value , typeName )
        {
            Breadth = b;
            Length = l;
        }

        /// <summary>
        /// Accepts a visitor and calls the appropriate method for visiting a rectangle.
        /// </summary>
        /// <param name="visitor">The visitor object used to visit this rectangle.</param>
        public override void Accept( Visitor visitor )
        {
            visitor.VisitRectangle( this );
        }
    }

}

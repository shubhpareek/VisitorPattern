using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Represents a triangle shape with specified side lengths.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Gets or sets the length of the first side of the triangle.
        /// </summary>
        public double Side1;

        /// <summary>
        /// Gets or sets the length of the second side of the triangle.
        /// </summary>
        public double Side2;

        /// <summary>
        /// Gets or sets the length of the third side of the triangle.
        /// </summary>
        public double Side3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with specified side lengths, value, and type name.
        /// </summary>
        /// <param name="s1">The length of the first side of the triangle.</param>
        /// <param name="s2">The length of the second side of the triangle.</param>
        /// <param name="s3">The length of the third side of the triangle.</param>
        /// <param name="value">The value associated with the triangle.</param>
        /// <param name="typeName">The type name of the triangle.</param>
        public Triangle( double s1 , double s2 , double s3 , string value , string typeName ) : base( value , typeName )
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        /// <summary>
        /// Accepts a visitor object to perform operations specific to the triangle.
        /// </summary>
        /// <param name="visitor">The visitor object used to visit this triangle.</param>
        public override void Accept( Visitor visitor )
        {
            visitor.VisitTriangle( this );
        }
    }

}

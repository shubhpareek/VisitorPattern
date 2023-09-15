using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Represents an abstract base class for various geometric shapes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Gets or sets the name of the shape.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the type name of the shape.
        /// </summary>
        public string Type;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class with a specified name, value, and type name.
        /// </summary>
        /// <param name="value">The name of the shape.</param>
        /// <param name="typeName">The type name of the shape.</param>
        public Shape( string value , string typeName )
        {
            Name = value;
            Type = typeName;
        }

        /// <summary>
        /// Accepts a visitor object to perform operations specific to the shape.
        /// </summary>
        /// <param name="visitor">The visitor object used to visit this shape.</param>
        public abstract void Accept( Visitor visitor );
    }

}

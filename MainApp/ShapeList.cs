using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MainApp
{
    /// <summary>
    /// Represents a list that stores various shapes.
    /// </summary>
    public class ShapeList
    {
        private readonly List<Shape> _shapes = new List<Shape>();

        /// <summary>
        /// Adds a shape to the list.
        /// </summary>
        /// <param name="shape">The shape to add.</param>
        public void Attach( Shape shape )
        {
            _shapes.Add( shape );
        }

        /// <summary>
        /// Removes a shape of a specific name and type from the list.
        /// </summary>
        /// <param name="name">The name of the shape to remove.</param>
        /// <param name="typeName">The type name of the shape to remove.</param>
        public void Remove( string name , string typeName )
        {
            foreach (Shape shape in _shapes.ToList()) // Use ToList() to avoid modifying the list while iterating
            {
                if (shape.Type == typeName && shape.Name == name)
                {
                    _shapes.Remove( shape );
                }
            }
            Console.WriteLine( "Shape with name {0} and type {1} has been removed." , name , typeName );
        }

        /// <summary>
        /// Accepts a visitor and performs operations on the shapes in the list.
        /// </summary>
        /// <param name="visitor">The visitor object used to visit the shapes.</param>
        public void Accept( Visitor visitor )
        {
            foreach (Shape shape in _shapes)
            {
                shape.Accept( visitor );
            }
            Console.WriteLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MainApp
{
    // stores shapes in a list 
    public class ShapeList
    {
        private readonly List<Shape> _shapes = new List<Shape>();

        // to add a shape 
        public void Attach( Shape shape )
        {
            _shapes.Add( shape );
        }
        // to remove a shape of a particular name and type 
        public void Remove( string name ,string typeName )
        {
            foreach (Shape shape in _shapes)
            {
                if(shape.Type == typeName && shape.Name == name) 
                { 
                    _shapes.Remove( shape );
                }   

            }
            Console.WriteLine("Shape with name {0} and type {1} has been removed ",name,typeName);
        }
        // for accepting a visitor on the shapes in the list .
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

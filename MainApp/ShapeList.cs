using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MainApp
{
    public class ShapeList
    {
        private readonly List<Shape> _shapes = new List<Shape>();
        public void Attach( Shape shape )
        {
            _shapes.Add( shape );
        }
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

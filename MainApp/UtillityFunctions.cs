using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MainApp
{
    public static class UtillityFunctions
    {
        //introduction of the app 
        public static void Intro()
        {
            Console.WriteLine( "Hello , you can add/remove shapes and calculate area , perimeter for all the objects " );
        }
        //list of actions that can be done 
        public static void ActionMenu()
        {
            Console.WriteLine( " Type 1 to add shape " );
            Console.WriteLine( " Type 2 to calculate perimeter of all shapes " );
            Console.WriteLine( " Type 3 to calculate area of all shapes " );
            Console.WriteLine( " Type 4 to remove a shape  " );
            Console.WriteLine( " Type 5 to exit  " );
        }

        // list of shapes 
        public static void AddShapeMenu() 
        { 
            Console.WriteLine( " Type 1 to add Circle " );
            Console.WriteLine( " Type 2 to add Triangle " );
            Console.WriteLine( " Type 3 to add Rectangle " );
        }

        // to add a circle 
        public static Circle AddCircle()
        {
            Console.WriteLine( " Enter Radius :" );
            double radius = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( " Enter Name :" );
            string name   = Console.ReadLine();
            Circle obj = new Circle( radius , name , "Circle" );
            return obj;
        }
        // to add a rectangle 
        public static Rectangle AddRectangle()
        {
            Console.WriteLine( " Enter length :" );
            double length = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( " Enter breadth :" );
            double breadth = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( " Enter Name :" );
            string name   = Console.ReadLine();
            Rectangle obj = new Rectangle( length, breadth , name , "Rectangle" );
            return obj;
        }
        // to add a triangle 
        public static Triangle AddTriangle()
        {
            Console.WriteLine( " Enter first side :" );
            double side1 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( " Enter second side :" );
            double side2 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( " Enter third side :" );
            double side3 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( " Enter Name :" );
            string name   = Console.ReadLine();
            Triangle obj = new Triangle( side1 ,side2 ,side3 , name , "Triangle" );
            return obj;
        }

        // to remove a shape from list 
        public static void RemoveShape(ShapeList shapes)
        {
            Console.WriteLine( "type the name of shape to be removed :" );
            string name = Console.ReadLine() ;
            Console.WriteLine( "What is the type of shape " );
            string type = Console.ReadLine() ;
            shapes.Remove(name,type);

        }
    }
}

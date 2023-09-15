using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MainApp
{
    /// <summary>
    /// Provides utility functions for interacting with the shape application.
    /// </summary>
    public static class UtillityFunctions
    {
        /// <summary>
        /// Displays an introduction message for the application.
        /// </summary>
        public static void Intro()
        {
            Console.WriteLine( "Hello, you can add/remove shapes and calculate area, perimeter for all the objects." );
        }

        /// <summary>
        /// Displays the action menu with a list of available actions.
        /// </summary>
        public static void ActionMenu()
        {
            Console.WriteLine( "Type 1 to add shape" );
            Console.WriteLine( "Type 2 to calculate perimeter of all shapes" );
            Console.WriteLine( "Type 3 to calculate area of all shapes" );
            Console.WriteLine( "Type 4 to remove a shape" );
            Console.WriteLine( "Type 5 to exit" );
        }

        /// <summary>
        /// Displays the menu for adding different shapes.
        /// </summary>
        public static void AddShapeMenu()
        {
            Console.WriteLine( "Type 1 to add Circle" );
            Console.WriteLine( "Type 2 to add Triangle" );
            Console.WriteLine( "Type 3 to add Rectangle" );
        }

        /// <summary>
        /// Adds a circle shape and returns it.
        /// </summary>
        /// <returns>The created Circle object.</returns>
        public static Circle AddCircle()
        {
            Console.WriteLine( "Enter Radius:" );
            double radius = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( "Enter Name:" );
            string name = Console.ReadLine();
            Circle obj = new Circle( radius , name , "Circle" );
            return obj;
        }

        /// <summary>
        /// Adds a rectangle shape and returns it.
        /// </summary>
        /// <returns>The created Rectangle object.</returns>
        public static Rectangle AddRectangle()
        {
            Console.WriteLine( "Enter length:" );
            double length = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( "Enter breadth:" );
            double breadth = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( "Enter Name:" );
            string name = Console.ReadLine();
            Rectangle obj = new Rectangle( length , breadth , name , "Rectangle" );
            return obj;
        }

        /// <summary>
        /// Adds a triangle shape and returns it.
        /// </summary>
        /// <returns>The created Triangle object.</returns>
        public static Triangle AddTriangle()
        {
            Console.WriteLine( "Enter first side:" );
            double side1 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( "Enter second side:" );
            double side2 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( "Enter third side:" );
            double side3 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine( "Enter Name:" );
            string name = Console.ReadLine();
            Triangle obj = new Triangle( side1 , side2 , side3 , name , "Triangle" );
            return obj;
        }

        /// <summary>
        /// Removes a shape from the list of shapes.
        /// </summary>
        /// <param name="shapes">The list of shapes to remove from.</param>
        public static void RemoveShape( ShapeList shapes )
        {
            Console.WriteLine( "Type the name of shape to be removed:" );
            string name = Console.ReadLine();
            Console.WriteLine( "What is the type of shape?" );
            string type = Console.ReadLine();
            shapes.Remove( name , type );
        }
    }

}

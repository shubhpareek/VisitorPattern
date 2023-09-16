using MainApp;
using ClassLibrary;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // these visitors are for testing .
        readonly AreaVisitor _areaVisitor = new AreaVisitor();
        readonly PerimeterVisitor _perimeterVisitor = new PerimeterVisitor();    

        /// <summary> for testing area visitor </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //creating shapelist for testing area visitor. 
            ShapeList shapeList = new ShapeList();
            Circle circle = new Circle(12.1,"football","Circle");
            Triangle triangle = new Triangle( 3.0 , 3.0 , 3.0 , "equilateral" , "Triangle");
            Rectangle rectangle = new Rectangle( 2.0 , 5.0 , "normal" , "Rectangle" );
            shapeList.Attach( rectangle );
            shapeList.Attach( circle    );
            shapeList.Attach( triangle  );

            //console output will be sent to this string writer for checking console ouptput.
            var sw = new StringWriter();
            Console.SetOut( sw );

            shapeList.Accept( _areaVisitor );
            //Expected 

            //Debug.WriteLine( result );

            // comparing final results
            string result = sw.ToString();
            string compare = "Area of Rectangle normal is 10\r\nArea of Circle football is 459.96058041208164\r\nArea of Triangle equilateral is 3.897114317029974\r\n\r\n";
            string[] comp = Regex.Split( compare, @"\s+" ); ;
            string[] resu = Regex.Split( result , @"\s+" ); ;

            for ( int i =0;i < comp.Length;i++ ) { if (comp[i] != resu[i]) { Debug.WriteLine( comp[i] );Debug.WriteLine( resu[i] ); Assert.Fail(); } }

            //Assert.AreEqual( compare.Split( new char[] { ' ' , '\n' , '\r' } ) , result.Split( new char[] { ' ' , '\n' , '\r' } ));

        }
        
        /// <summary> for testing perimeter visitor </summary>
        [TestMethod]
        public void TestMethod2()
        {
            //creating shapelist for testing perimeter visitor. 
            ShapeList shapeList = new ShapeList();
            Circle circle = new Circle(12.1,"football","Circle");
            Triangle triangle = new Triangle( 3.0 , 3.0 , 3.0 , "equilateral" , "Triangle");
            Rectangle rectangle = new Rectangle( 2.0 , 5.0 , "normal" , "Rectangle" );
            shapeList.Attach( rectangle );
            shapeList.Attach( circle    );
            shapeList.Attach( triangle  );

            //console output will be sent to this string writer for checking console ouptput.
            var sw = new StringWriter();
            Console.SetOut( sw );

            shapeList.Accept( _perimeterVisitor );
            //Expected 

            //Debug.WriteLine( result );

            string result = sw.ToString();

            // comparing final results
            string compare = "Perimeter of Rectangle normal is 14 \r\nPerimeter of Circle football is 76.026542216873\r\nPerimeter of Triangle equilateral is 9\r\n\r\n";
            string[] comp = Regex.Split( compare, @"\s+" ); ;
            string[] resu = Regex.Split( result , @"\s+" ); ;

            for ( int i =0;i < comp.Length;i++ ) { if (comp[i] != resu[i]) { Debug.WriteLine( comp[i] );Debug.WriteLine( resu[i] ); Assert.Fail(); } }
            
            
            //Assert.AreEqual( , result.Split(new char[]{' ','\n','\r'}) );

        }
        /// <summary>
        /// Test method to verify that the type of a Circle object matches the expected type.
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            Circle circle = new Circle( 12.1 , "football" , "Circle" );

            string expectedType = "Circle"; // This should match the type you set during object initialization
            string actualType = circle.Type;

            Assert.AreEqual( expectedType , actualType );
        }

        /// <summary>
        /// Test method to verify that the type of a Rectangle object matches the expected type.
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            Rectangle rectangle = new Rectangle( 2.0 , 5.0 , "normal" , "Rectangle" );

            string expectedType = "Rectangle"; // This should match the type you set during object initialization
            string actualType = rectangle.Type;

            Assert.AreEqual( expectedType , actualType );
        }

        /// <summary>
        /// Test method to verify that the type of a Triangle object matches the expected type.
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            Triangle triangle = new Triangle( 3.0 , 4.0 , 5.0 , "right" , "Triangle" );

            string expectedType = "Triangle";
            string actualType = triangle.Type;

            Assert.AreEqual( expectedType , actualType );
        }


    }
}

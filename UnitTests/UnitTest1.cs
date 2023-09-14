using MainApp;
using ClassLibrary;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // these visitors are for testing .
        readonly AreaVisitor _areaVisitor = new AreaVisitor();
        readonly PerimeterVisitor _perimeterVisitor = new PerimeterVisitor();    

        // <summary> for testing area visitor </summary>
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
            string compare = "Area of Rectangle normal is 10 \r\nArea of Circle football is 459.96058041208164\r\nArea of Triangle equilateral is 3.897114317029974\r\n\r\n";
            Assert.AreEqual( compare, result );

        }
        
        // <summary> for testing perimeter visitor </summary>
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
            Assert.AreEqual( compare, result );

        }
    }
}

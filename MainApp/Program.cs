
using ClassLibrary;
using MainApp;

UtillityFunctions.Intro();

ShapeList shapes = new ShapeList();

AreaVisitor areaVisitor = new AreaVisitor();

PerimeterVisitor perimeterVisitor = new PerimeterVisitor(); 

while (true)
{
    UtillityFunctions.ActionMenu();

    int type = Convert.ToInt32(Console.ReadLine());

    switch(type)
    {
        case 1:
            UtillityFunctions.AddShapeMenu();
            int shapeType = Convert.ToInt32(Console.ReadLine());
            switch(shapeType)
            {
                case 1:
                    try {
                        shapes.Attach( UtillityFunctions.AddCircle() );
                    }
                    catch {
                        Console.WriteLine( "Not a valid Circle" );
                    }
                    break;
                case 2:
                    try {
                        shapes.Attach( UtillityFunctions.AddTriangle() );
                    }
                    catch {
                        Console.WriteLine( "Not a valid Triangle" );
                    }
                    break;
                case 3:
                    try {
                        shapes.Attach( UtillityFunctions.AddRectangle() );
                    }
                    catch {
                        Console.WriteLine( "Not a valid Rectangle" );
                    }
                    break;
                default: 
                    Console.WriteLine( "Not a valid Shape" );

                    break;
            }

            break;
        case 2:
            shapes.Accept( perimeterVisitor );
            break;
        case 3: 
            shapes.Accept( areaVisitor );
            break;
        case 4:
            UtillityFunctions.RemoveShape( shapes );
            break;
        case 5:
            Console.WriteLine( " Thanks for using the app ." );
            return;
            
        default:
            Console.WriteLine( "Please type Correct number " );

            break;
    }
    Console.WriteLine( "-------------------------------------------" );



}

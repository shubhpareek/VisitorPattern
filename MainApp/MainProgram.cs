
using ClassLibrary;
using MainApp;

// intro of the app 
UtillityFunctions.Intro();

// object structure 
ShapeList shapes = new ShapeList();

AreaVisitor areaVisitor = new AreaVisitor();

PerimeterVisitor perimeterVisitor = new PerimeterVisitor(); 

while (true)
{
    // print the action menu
    UtillityFunctions.ActionMenu();

    //read console and store it
    int type = Convert.ToInt32(Console.ReadLine());

    switch(type)
    {
        //to add shape 
        case 1:
            //print shape menu
            UtillityFunctions.AddShapeMenu();
            //take input of the type of shape
            int shapeType = Convert.ToInt32(Console.ReadLine());

            switch(shapeType)
            {
                //to add circle
                case 1:
                    try {
                        shapes.Attach( UtillityFunctions.AddCircle() );
                    }
                    catch {
                        Console.WriteLine( "Not a valid Circle" );
                    }
                    break;
                //to add triangle
                case 2:
                    try {
                        shapes.Attach( UtillityFunctions.AddTriangle() );
                    }
                    catch {
                        Console.WriteLine( "Not a valid Triangle" );
                    }
                    break;
                //to add rectangle
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
        // for perimeter of all shapes 
        case 2:
            shapes.Accept( perimeterVisitor );
            break;
        // for area of all shapes 
        case 3: 
            shapes.Accept( areaVisitor );
            break;
        // for removing a shape 
        case 4:
            UtillityFunctions.RemoveShape( shapes );
            break;
        // exit 
        case 5:
            Console.WriteLine( " Thanks for using the app ." );
            return;
            
        default:
            Console.WriteLine( "Please type Correct number " );

            break;
    }
    Console.WriteLine( "-------------------------------------------" );



}

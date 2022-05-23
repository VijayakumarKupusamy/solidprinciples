// See https://aka.ms/new-console-template for more information
using LiskovSubstitution; 

static int Area(Rectangle rectangle)=>rectangle.Height*rectangle.Width;

Rectangle rectangle = new Rectangle(20, 45);

Console.WriteLine(Area(rectangle));

Rectangle recSquare = new Square();
recSquare.Width = 4;

Console.WriteLine(Area(recSquare));
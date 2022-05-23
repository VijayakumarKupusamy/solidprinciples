// See https://aka.ms/new-console-template for more information
using OpenClosed;
using OpenClosed.ProperDesign;

Console.WriteLine("Hello, World!");


var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

//Rigid Design

var productFilter = new OpenClosed.ProductFilter();
Console.WriteLine("Green products (Rigid Design):");
foreach (var product in productFilter.FilterByColor(products, Color.Green))
    Console.WriteLine($":- {product.Name} is green");

//PRoper Design
var properFilter = new OpenClosed.ProperDesign.ProductFilter();
Console.WriteLine("Red products (ProperDsign):");
foreach (var product in properFilter.Filter(products, new ColorSpecification(Color.Red)))
    Console.WriteLine($": - {product.Name} is Red");

Console.WriteLine("Small products");
foreach (var product in properFilter.Filter(products, new SizeSpecification(Size.Small)))
    Console.WriteLine($": - {product.Name} is Small");

Console.WriteLine("Large Green items");
foreach (var p in properFilter.Filter(products,
  new ColorandSizeSpecification(Color.Green , Size.Large)))
    Console.WriteLine($": - {p.Name} is Large and Green"); 

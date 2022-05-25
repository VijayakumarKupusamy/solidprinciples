// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");


var parent = new Person { Name = "Vijay" };
var child1 = new Person { Name = "Dhanya" };

var parent1 = new Person { Name = "Kuppusamy" };
var child11 = new Person { Name = "Vijay" };
var child12 = new Person { Name = "Malathi" };

var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1); 

relationships.AddParentAndChild(parent1, child11);
relationships.AddParentAndChild(parent1, child12);

//new Research(relationships);//Low Level design

//new Research(relationships as IRelationshipBrowser);//Low Level Design
var parentName = "Kuppusamy";
var childrens=relationships.FindAllChildrenOf(parentName);
foreach (var child in childrens)
    Console.WriteLine($"Children of parentName:{parentName} is {child.Name}");
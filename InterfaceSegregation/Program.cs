// See https://aka.ms/new-console-template for more information
using InterfaceSegregation.CleanApproach;

Console.WriteLine("Hello, World!");
IMultiFunctionDevice multiFunctionDevice = new MultiFunctionMachine( new Printer() as IPrinter, new Photocopier() as IScanner);

multiFunctionDevice.Print(new InterfaceSegregation.Document());

multiFunctionDevice.Scan(new InterfaceSegregation.Document());
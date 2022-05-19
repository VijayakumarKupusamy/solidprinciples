// See https://aka.ms/new-console-template for more information
using SingleResponsibility;
using System;
using System.Diagnostics;

var j = new Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");
Console.WriteLine(j);

var p = new Persistence();
var filename = @"journal.txt";
p.SaveToFile(j, filename);
Process.Start(filename);

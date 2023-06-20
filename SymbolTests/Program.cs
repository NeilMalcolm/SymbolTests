// See https://aka.ms/new-console-template for more information
using SymbolTests.Classes;

Console.WriteLine("Hello, World!");

var factory = new ClassFactory();

Console.WriteLine($"{factory.Get().Text} Wow!");

var name = Console.ReadLine();
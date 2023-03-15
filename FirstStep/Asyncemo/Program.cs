// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SDListDemo;

Console.WriteLine("Hello, World!");
Startup s= new Startup ();
await foreach (var number in s.GetFiles())
{
    Console.WriteLine(number.Id);
   
}
Console.ReadKey();
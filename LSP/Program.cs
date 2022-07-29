// See https://aka.ms/new-console-template for more information

using LSP.WithoutSOLID;
using LSP.WithSOLID;

AppleWithoutSOLID appleOne = new AppleWithoutSOLID();

Console.WriteLine(appleOne.GetColor());

AppleWithoutSOLID appleTwo = new OrangeWithoutSOLID();


Console.WriteLine(appleTwo.GetColor());

Console.WriteLine("\r\nwith SOLID:\r\n\r\n");


Fruit fruit = new OrangeWithSOLID();
Console.WriteLine(fruit.GetColor());

fruit = new AppleWithSOLID();
Console.WriteLine(fruit.GetColor());

Console.ReadKey();


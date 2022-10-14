// See https://aka.ms/new-console-template for more information
Console.Write("Введите число A: ");
int intA = int.Parse(Console.ReadLine());
Console.Write("Введите число B = ");
int intB = new Random().Next(1,20);
Console.WriteLine(intB);
int intSum = intA + intB;
Console.Write("A + B = ");
Console.WriteLine(intSum);
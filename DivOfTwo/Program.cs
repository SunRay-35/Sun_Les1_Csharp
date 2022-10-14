// See https://aka.ms/new-console-template for more information
Console.Write("Введите число A: ");
int intA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int intB = int.Parse(Console.ReadLine());
double dblDiv = Convert.ToDouble(value: intA) / Convert.ToDouble(intB);
Console.Write("A / B = ");
Console.WriteLine(dblDiv);
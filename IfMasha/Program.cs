// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string strUserName = Console.ReadLine();
if (strUserName.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(strUserName);
}
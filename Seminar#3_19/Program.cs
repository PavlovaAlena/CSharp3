// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Программа проверяет, является число палиндромом");
Console.WriteLine("");
Console.Write("Введите число ");
string? text = Console.ReadLine();

if (text == null || text.Length != 5)
{ Console.WriteLine("Число д.б. пятизначным!");}
else
{
    char[] txet = text.ToCharArray();
    Array.Reverse(txet);

    string ftext = new string(txet);

    if (text == ftext)
    { Console.WriteLine("Число является палиндромом"); }
    else
    { Console.WriteLine("Число не является палиндромом"); }
}
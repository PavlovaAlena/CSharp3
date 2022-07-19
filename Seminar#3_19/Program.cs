// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Программа проверяет, является число палиндромом");
Console.WriteLine("");
Console.Write("Введите число ");

//Первое решение
/* string? text = Console.ReadLine();

if (text == null || text.Length != 5)
{
    Console.WriteLine("Число д.б. пятизначным!");
}
else
{
    char[] txet = text.ToCharArray();
    Array.Reverse(txet);

    string ftext = new string(txet);

    if (text == ftext)
    { Console.WriteLine("Число является палиндромом"); }
    else
    { Console.WriteLine("Число не является палиндромом"); }
} */

//Второе решение
int uinput = Convert.ToInt32((Console.ReadLine()));
int remainder = 0;
int newnum = 0;
for (int i = uinput; i > 0; i = (i / 10))
{
    remainder = i % 10;
    newnum = (newnum*10) + remainder;
}
if (newnum == uinput)
{
    Console.WriteLine($"Число {uinput} является палиндромом");
}
else
{
    Console.WriteLine($"Число {uinput} не является палиндромом");
}
//Console.ReadKey();
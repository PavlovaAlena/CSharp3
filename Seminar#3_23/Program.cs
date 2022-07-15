// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Программа выдаёт таблицу кубов чисел от 1 до N");
Console.WriteLine("");
Console.Write("Введите число N ");
double x = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= x)
 {
    Console.WriteLine($"Куб числа {count}: {Math.Pow(count, 3)}");
    count++;
}
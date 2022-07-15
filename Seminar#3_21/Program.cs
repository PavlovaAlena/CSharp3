// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
Console.WriteLine("");

Console.WriteLine("Введите координаты первой точки: x, y,z - через пробел");
string[] TochkaA = Console.ReadLine().Split(' ');
Console.WriteLine("Введите координаты второй точки: x, y,z - через пробел");
string[] TochkaB = Console.ReadLine().Split(' ');

if (TochkaA.Length < 3 || TochkaB.Length < 3)
{
    Console.WriteLine("Координаты должны состоять из 3х чисел, разделенных пробелом!!!");
}
else
{
    int x1 = int.Parse(TochkaA[0]);
    int y1 = int.Parse(TochkaA[1]);
    int z1 = int.Parse(TochkaA[2]);

    int x2 = int.Parse(TochkaB[0]);
    int y2 = int.Parse(TochkaB[1]);
    int z2 = int.Parse(TochkaB[2]);

    double rez = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    Console.WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) в 3D пространстве {Math.Round(rez, 2)}");
}
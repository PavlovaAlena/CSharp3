// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
Console.WriteLine("");

// Первое решение с вводом трех координат одновременно
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

// Второе решение с "построчным" вводом координат
/* Console.WriteLine("Введите x1 ");
int x1 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите y1 ");
int y1 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите z1 ");
int z1 = Convert.ToInt32((Console.ReadLine()));

Console.WriteLine("Введите x2 ");
int x2 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите y2 ");
int y2 = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите z2 ");
int z2 = Convert.ToInt32((Console.ReadLine()));

if ((x1==0 && y1 == 0 && z1 == 0) || (x2==0 && y2 == 0 && z2 == 0))
{
    Console.WriteLine("Координаты должны отличаться от (0,0,0)");
}
else
{
    double rez = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    Console.WriteLine($"Расстояние между точками в 3D пространстве {rez}");
} */
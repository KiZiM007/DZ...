// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.WriteLine("Введите координаты точки А");
Console.Write("Координата по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки В");
Console.Write("Координата по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());


int Pifagor(int xx1, int yy1, int zz1, int xx2, int yy2, int zz2)
{
    int cat1 = xx1 - xx2;
    int cat2 = yy1 - yy2;
    int cat3 = zz1 - zz2;
    return cat1 * cat1 + cat2 * cat2 + cat3 * cat3;
}
double result = Math.Sqrt(Pifagor(x1, y1, z1, x2, y2, z2)); 
Console.Write($"Расстояние между точкой A({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) -> ");
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero)); 
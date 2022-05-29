// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();


static void FindingDistanceBetweenPoints(int xa, int xb, int ya, int yb, int za, int zb)
{
    double result = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
    System.Console.WriteLine($" ({xa},  {ya}, {za}, {xb}, {yb}, {zb})  - > {Math.Round(result, 2)}");
}
Console.WriteLine("Введите координаты первой точки A (x, y, z): ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки B (x, y, z): ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());
FindingDistanceBetweenPoints(xa, ya, za, xb, yb, zb);

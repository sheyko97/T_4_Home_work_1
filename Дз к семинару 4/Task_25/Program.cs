// Задание
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Пример
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void Stepen(int a, int b)
{

    int result = Convert.ToInt32(Math.Pow(a, b));
    Console.Write($"a в степени b = {result}");
}
System.Console.WriteLine("введите два числа");
Console.WriteLine("Введи свое первое число - ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи свое второе число - ");
int b = Convert.ToInt32(Console.ReadLine());


Stepen(a, b);
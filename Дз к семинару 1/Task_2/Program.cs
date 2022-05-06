/*
Задача 2: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введи 3 числа и мы тебе скажем большее из них ");
int a, b, c;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи свое третье число - ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();

Console.WriteLine("Введите число и мы скажем является ли этот день выходным");
int a;
a = Convert.ToInt32(Console.ReadLine());

if (a > 5 && a < 8)
{
    Console.WriteLine("да");
}
else if (a > 7)
{
    Console.WriteLine("ошибка");
}
else
{
    Console.WriteLine("нет");
}
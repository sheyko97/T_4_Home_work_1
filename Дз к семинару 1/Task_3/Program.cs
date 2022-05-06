/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */

Console.Write("Введите число: ");
int a;
a = Convert.ToInt32(Console.ReadLine());

bool no = false;
bool yes = true;

Console.WriteLine(a % 2 == 0);
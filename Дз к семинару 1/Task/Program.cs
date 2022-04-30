/* Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

    Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
    int a, b;
    Console.WriteLine("Введи свое первое число - ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи свое второе число - ");
    b = Convert.ToInt32(Console.ReadLine());

    bool Var0 = a > b;
    bool Var1 = a == b;
    bool Var2 = a < b;

    if (Var0)
    {
        Console.WriteLine($"Число {a} больше чем {b}");
    }
    else if (Var1)
    {
        Console.WriteLine($"Числа {a} и {b} равны");
    }
  else
    {
        Console.WriteLine($"Число {b} больше чем {a}");
    }
    
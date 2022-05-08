/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/
Console.Clear();

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= number)
{
    if (count >= number - 1)
    {
        Console.Write(count);
    }
    else 
    {
        Console.Write(count + ", ");
    }
    count = count + 2;
}


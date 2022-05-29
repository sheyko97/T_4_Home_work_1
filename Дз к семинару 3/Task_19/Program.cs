
/*Задача 19: Напишите программу, которая принимает
на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/


bool Palindrom(string number)
{
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}
try
{
    Console.WriteLine("Введите число: ");
    UInt32 enterNum = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine($"Введенное число {enterNum} -палиндром?");
    if (Palindrom(Convert.ToString(enterNum) ?? "0"))
    {
        Console.WriteLine($"{enterNum} -> ДА");
    }
    else
    {
        Console.WriteLine($"{enterNum} -> НЕТ");
    }
}
catch
{
    Console.WriteLine ("Ошибка! Введено не подходящее число!");
}
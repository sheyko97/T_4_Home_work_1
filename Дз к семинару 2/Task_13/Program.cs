/* 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/

int randomNumber = new Random().Next(10,10000);
Console.WriteLine(randomNumber);

if (randomNumber < 99)
{
Console.WriteLine("третьей цифры нет");
}
else
{
 Console.WriteLine((randomNumber / 10) % 10);
}

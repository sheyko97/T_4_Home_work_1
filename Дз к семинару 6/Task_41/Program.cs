// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();



int[] FillArray(int[] Array2)
{
    System.Console.WriteLine($"Введите {Array2.Length} значений: ");
    for (int i = 0; i < Array2.Length; i++)
    {
        Array2[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array2;
}

int CountArray(int[] resultArray )
{
int count = 0;
for (int i = 0; i < resultArray.Length; i++)
{
    if(resultArray[i] > 0)
    {
        count++;
    }
}
return count;
}



void PrintArray(int[] Array3)
{
    int count2 = CountArray(Array3);

    System.Console.Write("[");
    for (int i = 0; i < Array3.Length; i++)
    {
        System.Console.Write(Array3[i]);
        if (i != Array3.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write($"] -> {count2}");

}



Console.Write("Введите размер массива ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[sizeArray];

int[] print = FillArray(Array);
PrintArray(print);
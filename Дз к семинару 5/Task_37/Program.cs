// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Clear();

int[] FillArray(int[] Array) // принимает массив 
{
    Random randomNumber = new Random();
    int[] resulArray = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        resulArray[i] = randomNumber.Next(1, 10);
    }
    return resulArray;
}


int[] ProductNumber(int[] Array2)
{
    int newSize = 0;
    int sizeArr = Array2.Length;
    int[] ResArr;
    if (sizeArr % 2 == 0)
    {
        newSize = sizeArr / 2;
        ResArr = new int[newSize];
        for (int i = 0; i < newSize; i++)
        {
            ResArr[i] = Array2[i] * Array2[sizeArr - 1 - i];
        }
    }

    else
    {
        newSize = sizeArr / 2 + 1;
        ResArr = new int[newSize];
        for (int i = 0; i < newSize - 1; i++)
        {
            ResArr[i] = Array2[i] * Array2[sizeArr - 1 - i];
        }
        ResArr[newSize - 1] = Array2[sizeArr / 2];
    }
    return ResArr;
}


// вывод Массива

void PrintArray(int[] Array3)
{
    System.Console.Write("[");
    for (int i = 0; i < Array3.Length; i++)
    {
        System.Console.Write(Array3[i]);
        if (i != Array3.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write($"] ");

}
System.Console.WriteLine("введите размеер");
int size = Convert.ToInt32(Console.ReadLine());
int[] Number = new int[size];//Для ввода размера массива.

int[] ResultArray = FillArray(Number);
int[] Result2 = ProductNumber(ResultArray);

PrintArray(ResultArray);
PrintArray(Result2);

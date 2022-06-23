
// Задача   34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] FillArray(int[] Array) // принимает массив 
{
    Random randomNumber = new Random();
    int[] resulArray = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        resulArray[i] = randomNumber.Next(99, 1000);
    }
    return resulArray;
}

// функцию для посчета положительных чисел

int EvenNumber(int[] Array2)
{
    int temp = 0;
    for (int i = 0; i < Array2.Length; i++)
    {
        if (Array2[i] % 2 == 0)
        {
            temp++;
        }
    }
    return temp;
}

// вывод Массива

void PrintArray(int[] Array3)
{
    System.Console.Write("[");
    int Even = EvenNumber(Array3);
    for (int i = 0; i < Array3.Length; i++)
    {
        System.Console.Write(Array3[i]);
        if(i!= Array3.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write($"] -> {Even} ");
    
}


System.Console.WriteLine("введите размеер");
int size = Convert.ToInt32(Console.ReadLine());
int[] Number = new int[size];//Для ввода размера массива.

int[] ResultArray = FillArray(Number);
PrintArray(ResultArray);



Console.Clear();
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


/*Я пока не смог дорешать эту задачу! :( */

void MyArray(int[] array)
{
    for (int i = 0; i <= array.Length; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }


}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int result = PrintArray(8);
Console.WriteLine($" {result}");




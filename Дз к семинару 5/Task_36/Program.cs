// Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




void RandomNumberArray(int[] array)
{
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.Next(-999, 999);
    }
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
}

int ResultArray(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result = result + array[i];

    }
    return result;
}
System.Console.WriteLine(" Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] randArr = new int[sizeArr];
RandomNumberArray(randArr);
int sumArr = ResultArray(randArr);
System.Console.WriteLine($"- > {sumArr}");
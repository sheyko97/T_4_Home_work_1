// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

System.Console.WriteLine("Задайте двумерный массив размером m*n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array2D = new double[m, n];

double[,] FillArray2D(double[,] Array2D2, int num = 10)
{
    Random random = new Random();
    for (int i = 0; i < Array2D2.GetLength(0); i++)
    {

        for (int j = 0; j < Array2D2.GetLength(1); j++)
        {
            Array2D2[i, j] = Math.Round((random.NextDouble() * num) + (random.NextDouble() * -num), 2);
        }
    }
    return Array2D2;

}


void PrintArray(double[,] Array2D3)
{
    for (int i = 0; i < Array2D3.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D3.GetLength(1); j++)
        {
            System.Console.Write($"{Array2D3[i, j]} \t");
        }
        System.Console.WriteLine();

    }

}


double[,] print = FillArray2D(Array2D, 5);
PrintArray(print);
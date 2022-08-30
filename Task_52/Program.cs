// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
int[,] array = new int[5, 4];
Random rnd = new Random();

int[,] ArrayTwoSize(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = Convert.ToInt32(rnd.Next(0, 21));
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t  ");
        Console.WriteLine();
    }
    return arr;
}

void ArithmeticMeanColumn()
{
    for (int i = 0; i < 4; i++)
    {
        double srAr = 0;
        for (int t = 0; t < 4; t++)
        {
            srAr += array[t, i];

        }
        srAr /= 3;
        srAr = Math.Round(srAr, 2);
        Console.WriteLine($"Cреднее арифметическое элементов столбца = {srAr}");
    }
}


int[,] arr1 = ArrayTwoSize(array);
Console.WriteLine(arr1);
ArithmeticMeanColumn();





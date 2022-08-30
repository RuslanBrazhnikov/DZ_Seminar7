// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();
Console.WriteLine("Введите размеры массива по очереди через \"Ввод\": ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
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

void InputCoordinat(int a, int b)
{
    Console.WriteLine("Введите координаты по очереди через \"Ввод\": ");
    int a1 = Convert.ToInt32(Console.ReadLine());
    int b1 = Convert.ToInt32(Console.ReadLine());
    if (a1 > m || b1 > n)
        Console.WriteLine("Такого элемента в массиве нет!");
    else
    {
        object c = array.GetValue(a1, b1);
        Console.WriteLine(c);
    }
}

int[,] arr1 = ArrayTwoSize(array);

Console.WriteLine(arr1);
InputCoordinat(m, n);
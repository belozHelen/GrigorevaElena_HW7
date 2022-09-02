// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
// (В С# если делить целые числа на целые, то и на выходе тоже будут целые числа. 
// Если какое-то одно из них будет вещественным, то результат будет дробный)


Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArrayRandomNumbres(array);
Print2DArray(array);
CalculateAndPrint(array);

void CalculateAndPrint(int[,] array)
{
    Console.WriteLine();
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) {
        int sr = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            sr += array[i,j];
        }
        sum[i] = sr / array.GetLength(1);
    }

    string text = "";
    for (int i = 0; i < sum.Length; i++) {
        text += sum[i] + " ";
    }
    Console.WriteLine(text);
}

void FillArrayRandomNumbres(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++){ 
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

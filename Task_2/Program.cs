// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// (Можно самим задать количество строк и столбцов)

Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArrayRandomNumbres(array);
Print2DArray(array);

Console.WriteLine();
Console.WriteLine("Введите номер в строке позиции элемента: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер в столбце позиции элемента: ");
int y = Convert.ToInt32(Console.ReadLine());
FoundElem(array, x, y);

void FoundElem(int[,] array, int x, int y) 
{
    if (x < array.GetLength(0) && y < array.GetLength(1)) {
        Console.WriteLine();
        Console.WriteLine(array[x-1, y-1]);
    } else {
        Console.WriteLine("Не существует значения этом диапазоне в массиве");
    }
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
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++){ 
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

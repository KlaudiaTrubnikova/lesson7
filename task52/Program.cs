// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Clear();
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[,] Random2Dim(int Rows, int Collumns, int startNums, int endNums) 
{
    int[,] array = new int[Rows, Collumns];


    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = new Random().Next(startNums, endNums); 
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            System.Console.Write($"{array[row, col]} ");

        }
        System.Console.WriteLine("");
    }
}

void ShowColumnAverage(int[,] array) 
{
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        System.Console.WriteLine($"{Math.Round(result/array.GetLength(0), 1)}");
        result = 0;
    }
}


int rows = Prompt("Количество строк");
int coll = Prompt("Количество столбцов");

int[,] RandomArray = Random2Dim(rows,coll,1,9);
PrintArray(RandomArray);
System.Console.WriteLine("");

ShowColumnAverage(RandomArray);
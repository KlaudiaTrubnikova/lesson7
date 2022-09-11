// Задача 50. Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();
Console.WriteLine (" Введите количество строк ");
int m = Convert.ToInt32 (Console.ReadLine( ));
Console.WriteLine (" Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine( ));
int[,] array = new int [m, n];
   for (int i = 0; i < array.GetLength(0); i++) 
{     
    for (int j = 0; j < array.GetLength(1); j++)        
    array [i, j] = Convert.ToInt32(new Random().Next(1,21));
}
    for (int i = 0; i < array.GetLength(0); i++) 
    
{
    for (int j = 0; j < array.GetLength(1); j++) 
Console.Write(array[i,j] + "\t  ");      
Console.WriteLine();
}  
Console.WriteLine("Введите номер строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца"); 
int b = Convert.ToInt32(Console.ReadLine());
if (a>m && b>n)  Console.WriteLine("такого числа нет");
else  {  object c = array.GetValue(a-1,b-1);  
Console.WriteLine("искомое число: ");
Console.WriteLine(c);  
}
//только я все же не поняла, мы ищем число по координатам или координаты числа?
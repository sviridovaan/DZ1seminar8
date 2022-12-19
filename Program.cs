//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
void ShowArray(int [,] array)
{
    for (int i = 0; i<array.GetLength(0) ; i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int [,] array = new int [rows, columns]; 
    for (int i = 0; i<rows ; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array [i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");

int [,] matrix= CreateRandomArray(m, n, 1, 10);
Console.WriteLine("Рандомная матрица: ");
ShowArray(matrix);

void CreateNewArray (int [,] arr2)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (arr2[i, k] < arr2[i, k + 1])
        {
          int res = arr2[i, k + 1];
          arr2[i, k + 1] = arr2[i, k];
          arr2[i, k] = res;
        }
      }
    }
  }
}
CreateNewArray(matrix);
Console.WriteLine("Результирующая матрица: ");
ShowArray(matrix);

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
ShowArray(Create2dArrya());
double [,] Create2dArrya() // Создание двух мерного массива
    {
        Console.Write("Input number of rows: ");
        int row  = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of colums: ");
         int colums  = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input min possible value: ");
        int min_Value  = Convert.ToInt32(Console.ReadLine());;
        Console.Write("Input max possible value: ");
        int max_Value  = Convert.ToInt32(Console.ReadLine());

        double [,] CreateArrya = new double [row,colums];
        for(int i=0; i<row; i++)
        for(int j=0; j<colums;j++)
            {
                CreateArrya [i,j]= RandomDouble(min_Value,max_Value,1);
            }
    return CreateArrya;
    }

void ShowArray (double[,] array)
    {
    for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
            Console.WriteLine(" ");
        }
    }
double RandomDouble(int minVal, int maxVal, int round)
    {
            double m= new Random().Next(minVal , maxVal);
            double k= new Random().NextDouble();
            return Math.Round(m+k,1);
    }
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int [,] CreateArrya = {{1,2,34,345,345},{4,6,345,345,32},{42,61,34,34,3}}; // Массив задан статически, разобраться как это делается 
ShowArray(CreateArrya);
Console.Write("Input number of rows, start from (0): ");
int row  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums, start from (0): ");
int colums  = Convert.ToInt32(Console.ReadLine());
FindNum(CreateArrya,row,colums);

void FindNum (int[,] array, int row, int colums)
    {
        if( row <= array.GetLength(0) &&  colums <= array.GetLength(1) ){
        int num = array[row,colums];
        Console.WriteLine($"You number is {array[row,colums]}");
        }else{
         Console.WriteLine("Out of range");
        }       
    }
void ShowArray (int[,] array)
    {
    for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
            Console.WriteLine(" ");
        }
    }
*/
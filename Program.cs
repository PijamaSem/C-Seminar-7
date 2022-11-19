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
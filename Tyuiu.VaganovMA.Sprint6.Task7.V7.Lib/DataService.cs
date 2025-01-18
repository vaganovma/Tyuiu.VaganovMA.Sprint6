using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.VaganovMA.Sprint6.Task7.V7.Lib;

public class DataService : ISprint6Task7V7
{
    public int[,] GetMatrix(int array[,], int n1,int n2, int c, int k, int l)//string path)
    {
        int rows;
        int columns;
        Random random = new Random();
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        { 
            for (int j = 0; j < columns; j++)
            {
                // Чередуем отрицательные и положительные числа
                if (j % 2 == 0) // Чётный индекс получит положительное число
                {
                    matrix[i, j] = random.Next(n1, n2 + 1);
                }
                else // Нечётный индекс получит отрицательное число
                {
                    matrix[i, j] = random.Next(n1, 0);
                }
            }
        }

        return matrix;


        //int rows;
        //int columns;
        //string text = File.ReadAllText(path);
        //text = text.Replace('\n', '\r');
        //string[] lines = text.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
        //rows = lines.Length;
        //columns = lines[0].Split(';').Length;
        //int[,] array = new int[rows, columns];

        //for (int i = 0; i < rows; i++)
        //{
        //    string[] line_r = lines[i].Split(';');
        //    for (int j = 0; j < columns; j++)
        //    {
        //        array[i, j] = Convert.ToInt32(line_r[j]);
        //    }
        //}
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < columns; j++)
        //    {
        //        if (j == 1)
        //        {
        //            if (array[i, j] % 2 == 0)
        //            {
        //                array[i, j] = 4;
        //            }
        //        }
        //    }
        //}
        //return array;
    }
}
//Дан целочисленный двумерный массив N (N>1) на М (М>1) элементов, заполненный случайными числами в заданном диапазоне (от n1 до n2) с чередованием отрицательного и положительного числа в строках. Найти количество всех отрицательных элементов массива, кроме элементов с номерами от К до L (нумерация начинается с нуля) включительно в заданном столбце C. Произвести проверку на корректность ввода интервальных значений (-n1<+n2,K>L, C и т.д.).
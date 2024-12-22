using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task3.V20.Lib;

public class DataService : ISprint6Task3V20
{
    public int[,] Calculate(int[,] matrix)
    {
        int s = 0;
        int rows = matrix.GetUpperBound(0) + 1;//кол строк
        int stolb = matrix.Length / rows;      //кол столбцов
        //int minzn = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[4, j] % 2==0)
                {
                    matrix[4, j] = 0;
                }
            }
        }
        return matrix;
    }
} 
 

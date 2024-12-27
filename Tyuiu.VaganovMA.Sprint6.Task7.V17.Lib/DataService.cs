using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task7.V17.Lib;

public class DataService : ISprint6Task7V17
{
    public int[,] GetMatrix(string path)
    {
        int rows;
        int columns;
        string text = File.ReadAllText(path);
        text = text.Replace('\n', '\r');
        string[] lines = text.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
        rows = lines.Length;
        columns = lines[0].Split(';').Length;
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] line_r = lines[i].Split(';');
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = Convert.ToInt32(line_r[j]);
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j == 1)
                {
                    if (array[i, j] %2== 0)
                    {
                        array[i, j] = 4;
                    }
                }
            }
        }
        return array;
    }
} 
 

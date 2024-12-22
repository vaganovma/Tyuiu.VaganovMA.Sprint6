using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task5.V4.Lib;

public class DataService : ISprint6Task5V4
{
    string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";
                    //@"C:\Users\Ignis\source\repos\Tyuiu.VaganovMA.Sprint6\File\InPutDataFileTask5V4.txt";
    public int len = 0;
    public double[] LoadFromDataFile(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                len++;
            }
        }
        double[] numsArray = new double[len];

        int index = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                numsArray[index] = Math.Round(Convert.ToDouble(line), 3);
                index++;
            }
        }
        //numsArray = numsArray.Where(val => val > 0).ToArray();
        numsArray = numsArray.Where(val =>val % 1 == 0).ToArray(); 
        return numsArray;

    }
}

 

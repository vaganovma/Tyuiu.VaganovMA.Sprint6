using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task1.V9.Lib;

public class DataService : ISprint6Task1V9
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        //double[] valueArray;  //обновляем пустой массив
        //int len = (stopValue - startValue) + 1;    // вычисляем длинну массива    
        //valueArray = new double[len];//создаем массив с указанной длинной
        //double y;
        //int count = 0;
        //for (int x = startValue; x <= len - 1; x++)
        //{
        //    // valueArray[x]
        //    double z = 2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1));
        //    y = Math.Round(z, 2);//округляем
        //    valueArray[count] = y;//присваиваем значение в массив с индексом каунт
        //}
        //return valueArray;
        double[] valueArray = new double[11];  //обновляем пустой массив
        
        for (int x = startValue; x < 11 - 1; x++)
        {
            // valueArray[x]
            double z = 2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1));
            double y = Math.Round(z, 2);//округляем
            valueArray[x] = y;//присваиваем значение в массив с индексом каунт
        }
        return valueArray;
    }
}



        
using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task2.V28.Lib;

public class DataService : ISprint6Task2V28
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] valueArray;  //обновляем пустой массив
        int len = (stopValue - startValue) + 1;    // вычисляем длинну массива    
        valueArray = new double[len];//создаем массив с указанной длинной
        double y;
        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            // valueArray[x]
            double z = ((Math.Sin(x) - 2 * x) / ((3 * x) - 1)) + Math.Sin(x) - 3 * x + 2;
            y = Math.Round(z, 2);//округляем
            valueArray[count] = y;//присваиваем значение в массив с индексом каунт
            count++;
        }
        return valueArray;
        //42424244242424242424444444444444444444444444444444422222222222222222222222222222222222222222222222222222222222222222222222
        //double[] valueArray = new double[11];  //обновляем пустой массив

        //for (int x = startValue; x < 11 - 1; x++)
        //{
        //    // valueArray[x]
        //    double z = ((Math.Sin(x) - 2 * x) / ((3 * x) - 1)) + Math.Sin(x) - 3 * x + 2;
        //    double y = Math.Round(z, 2);//округляем
        //    valueArray[x] = y;//присваиваем значение в массив с индексом каунт
        //}
        //return valueArray;
    }
}
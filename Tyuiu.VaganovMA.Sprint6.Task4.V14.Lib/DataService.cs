using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task4.V14.Lib;

public class DataService : ISprint6Task4V14
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] valueArray;  //��������� ������ ������
        int len = (stopValue - startValue) + 1;    // ��������� ������ �������    
        valueArray = new double[len];//������� ������ � ��������� �������
        double y;
        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            // valueArray[x]
            double z =  2 * x - 4 + (2*x-1)/ (Math.Sin(x)+ 1);
            y = Math.Round(z, 2);//���������
            valueArray[count] = y;//����������� �������� � ������ � �������� �����
            count++;
        }
        return valueArray;
    }
}

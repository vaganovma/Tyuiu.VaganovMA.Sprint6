using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task0.V13.Lib;

public class DataService : ISprint6Task0V13
{
    public double Calculate(int x)
    {
        double res = Math.Pow((double)x, 3) / (Math.Pow((double)x, 2)-1);
        return Math.Round(res, 3);
    }
}


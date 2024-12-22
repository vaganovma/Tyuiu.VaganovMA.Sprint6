using Tyuiu.VaganovMA.Sprint6.Task2.V28.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {        
        DataService ds = new DataService();

        int startValue = -5;
        int endValue = 5;
        int LenOfValue = endValue - startValue + 1;
        double[] WaitArray = new double[LenOfValue];

        WaitArray[0] = 17.27;
        WaitArray[1] = 14.08;
        WaitArray[2] = 10.27;
        WaitArray[3] = 6.65;
        WaitArray[4] = 3.87;
        WaitArray[5] = 2.00;
        WaitArray[6] = -0.74;
        WaitArray[7] = -3.71;
        WaitArray[8] = -7.59;
        WaitArray[9] = -11.55;
        WaitArray[10] = -14.74;

        double[] result = new double[LenOfValue];
        result = ds.GetMassFunction(startValue, endValue);
        CollectionAssert.AreEqual(WaitArray, result);
    } 
}  

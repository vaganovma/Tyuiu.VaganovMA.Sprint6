using Tyuiu.VaganovMA.Sprint6.Task1.V9.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        int len = stopValue - startValue + 1;

        double[] valueWaitArray;
        valueWaitArray = new double[len];

        valueWaitArray[] = 7.83;
        valueWaitArray[] = ;
        valueWaitArray[] = ;
        valueWaitArray[] = ;
        valueWaitArray[] = ;

        double[] res;
        res = new double[len];
        res = ds.GetMassFunction(startValue, stopValue);
        CollectionAssert.AreEqual(valueWaitArray, res);
    }
}

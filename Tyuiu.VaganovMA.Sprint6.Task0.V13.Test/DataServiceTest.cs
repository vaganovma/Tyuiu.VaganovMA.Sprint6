using Tyuiu.VaganovMA.Sprint6.Task0.V13.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        double res = ds.Calculate(3);
        double wait = 3.375;
        //string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTask0.txt"; 
        //FileInfo fileInfo = new FileInfo(path); 
        //bool fileExit = fileInfo.Exists; 
        //bool wait = true; 
        Assert.AreEqual(wait, res);//fileExit); 
   } 
} 
   

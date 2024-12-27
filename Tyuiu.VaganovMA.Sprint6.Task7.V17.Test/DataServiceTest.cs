using Tyuiu.VaganovMA.Sprint6.Task7.V17.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
       string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTask7.txt"; 
       FileInfo fileInfo = new FileInfo(path); 
       bool fileExit = fileInfo.Exists; 
       bool wait = true; 
       Assert.AreEqual(true, fileExit); 
   } 
} 
   //не делал!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 

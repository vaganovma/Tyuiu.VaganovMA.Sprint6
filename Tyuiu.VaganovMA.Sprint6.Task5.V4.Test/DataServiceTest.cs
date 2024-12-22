using Tyuiu.VaganovMA.Sprint6.Task5.V4.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
       string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTask5.txt"; 
       FileInfo fileInfo = new FileInfo(path); 
       bool fileExit = fileInfo.Exists; 
       bool wait = true; 
       Assert.AreEqual(true, fileExit); 
   } 
} 
   //не делал!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 

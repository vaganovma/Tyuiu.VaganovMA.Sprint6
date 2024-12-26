using tyuiu.cources.programming.interfaces.Sprint6; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint6.Task6.V23.Lib;

public class DataService : ISprint6Task6V23
{
    //public string CollectTextFromFile(string path, string openFilePath)
    //{
    //    string resstr = "";

    //    using (StreamReader sr = new StreamReader(path))
    //    {
    //        string line;
    //        while ((line = sr.ReadLine()) != null)
    //        {
    //            string[] array = line.Split(" ");
    //            if (array[0] == "")
    //            {
    //                break;
    //            }
    //            //Array.Reverse(array);
    //            //resstr += array[1] + " ";
    //            if (array.Length > 1 && array[1].Contains('s'))
    //            {
    //                resstr += array[1] + " "; // ��������� �����, ���� ��� �������� 's'
    //            }
    //        }

    //    }

    //    return resstr.Trim();
    //}

    public string CollectTextFromFile(string path)
    {

        string[] lines = File.ReadAllLines(path);
        string text = string.Join(" ", lines);
        string[] words = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var result = words.Where(word => word.Contains("s"));
        return string.Join(" ", result);
        //    // throw new NotImplementedException();
        //    string resstr = "";

        //    using (StreamReader sr = new StreamReader(path))

        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            string[] array = line.Split(" ");
        //            if (array[0] == "")
        //            {
        //                break;
        //            }
        //            //Array.Reverse(array);
        //            //resstr += array[1] + " ";
        //            if (array[1].Contains('s'))//if (array.Length > 1 && array[1].Contains('s'))
        //            {
        //                resstr += array[1] + " "; // ��������� �����, ���� ��� �������� 's'
        //            }
        //        }

        //    }

        //    return resstr.Trim();
        //}
        //4242424244242424242424244424444224422422422422424422242222222222222222222222222222222222222222442444444444444444444

        //string resstr = "";

        //using (StreamReader sr = new StreamReader(path))
        //{
        //    string line;
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        // ��������� ������ �� �����
        //        string[] array = line.Split(" ");

        //        // ���������, �������� �� ������ �����
        //        if (array.Length == 0 || array[0] == "")
        //        {
        //            break;
        //        }

        //        // ���������� ��� ����� � ������� ������
        //        foreach (var word in array)
        //        {
        //            // ���������, �������� �� ����� 's' � ��������� ��� � ���������
        //            if (word.Contains('s'))
        //            {
        //                resstr += word + " ";
        //            }
        //        }
        //    }
        //}

        //return resstr.Trim();



    }
}

//������� ����� � ������� ����������� s � �������������� ������, ��� ���� �������� ���������


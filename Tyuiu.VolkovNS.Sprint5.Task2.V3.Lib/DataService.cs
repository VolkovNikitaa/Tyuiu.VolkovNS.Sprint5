using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VolkovNS.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
                File.Delete(path);
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if(matrix[i, j]%2 == 1)
                        matrix[i, j] = 0;
            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (j != matrix.GetLength(1)-1)
                        str += matrix[i, j] + ";";
                    else str += matrix[i, j];
                if (i != matrix.GetLength(0) - 1)
                    File.AppendAllText(path, str + Environment.NewLine);
                else
                    File.AppendAllText(path, str);
                str = "";
            }
            return path;

        }
    }
}

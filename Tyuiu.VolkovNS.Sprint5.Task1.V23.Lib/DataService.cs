using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VolkovNS.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
                File.Delete(path);
            double y;
            string strY;
            for(int i = startValue; i <= stopValue; i++)
            {
                if (i == -2)
                    y = 0;
                else 
                    y = Math.Round(Math.Cos(i) + Math.Cos(i) / (i + 2) - 3 * i,2);
                strY = Convert.ToString(y);
                if (i!=stopValue)
                    File.AppendAllText(path, strY + Environment.NewLine);
                else
                    File.AppendAllText(path, strY);
            }

            return path;
        }
    }
}

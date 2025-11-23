using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VolkovNS.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempFileName()}OutPutFileTask0.txt";
            double y = (Math.Pow(x, 2) + 1)/Math.Pow(4*x*x-3, 0.5);
            y = Math.Round(y,2);
            File.WriteAllText(path,Convert.ToString(y));
            return path;
        }
    }
}

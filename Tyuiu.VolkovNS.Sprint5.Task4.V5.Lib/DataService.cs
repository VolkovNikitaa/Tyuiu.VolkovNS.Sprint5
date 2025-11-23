using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VolkovNS.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string strY = strX.Replace(".", ",");
            double res = Math.Round(4.26 * Convert.ToDouble(strY) / Math.Sin(Convert.ToDouble(strY)), 3); 
            return res;
        }
    }
}

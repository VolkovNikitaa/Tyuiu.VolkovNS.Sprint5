using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VolkovNS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                line = line.Replace(".", ",");
                string[] digits = line.Split(' ');
                for (int i = 0; i < digits.Length; i++) 
                { 
                    if (Convert.ToDouble(digits[i])>res && Convert.ToDouble(digits[i])%2 ==0)
                        res = Convert.ToDouble(digits[i]);
                }

                
            }
                
            return Factorial(Convert.ToInt32(res));
        }
    }
}

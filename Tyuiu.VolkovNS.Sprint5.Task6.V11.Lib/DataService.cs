using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VolkovNS.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int i = 0;
                
                foreach (char c in line) {
                    if (Char.IsLetter(c))
                        i++;
                    else
                    {
                        if (i == 6)
                        {
                            count++;
                        }
                        i = 0;
                    }
                }   
            }
            return count;
        }
    }
}

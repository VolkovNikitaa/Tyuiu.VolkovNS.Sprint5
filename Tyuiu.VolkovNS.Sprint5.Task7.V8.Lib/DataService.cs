using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VolkovNS.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string path1 = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path1);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
                File.Delete(path1);
            string res="";
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line = reader.ReadLine();
                foreach (char c in line)
                {
                    if (c >= 'А' && c <= 'Я')
                        res.Append((char)(c + 32));
                    else if (c == 'Ё')
                        res.Append('ё');
                    else
                        res.Append(c);

                }
            }
            File.WriteAllText(path1, res);
            return path1;
        }
    }
}

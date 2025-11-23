using System.IO;
namespace Tyuiu.VolkovNS.Sprint5.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Nikita\source\repos\Tyuiu.VolkovNS.Sprint5\Tyuiu.VolkovNS.Sprint5.Task0.V21\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

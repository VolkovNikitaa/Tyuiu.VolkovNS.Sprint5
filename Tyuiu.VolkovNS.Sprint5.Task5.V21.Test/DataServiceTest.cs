using Tyuiu.VolkovNS.Sprint5.Task5.V21.Lib;

namespace Tyuiu.VolkovNS.Sprint5.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("c:\\", "DataSprint5\\", "InPutDataFileTask5V21.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

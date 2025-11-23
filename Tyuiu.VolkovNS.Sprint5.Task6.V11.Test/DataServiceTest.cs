using Tyuiu.VolkovNS.Sprint5.Task6.V11.Lib;

namespace Tyuiu.VolkovNS.Sprint5.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("c:\\", "DataSprint5\\", "InPutDataFileTask6V11.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

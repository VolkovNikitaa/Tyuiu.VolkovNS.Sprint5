using Tyuiu.VolkovNS.Sprint5.Task4.V5.Lib;
namespace Tyuiu.VolkovNS.Sprint5.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("c:\\", "DataSprint5\\", "InPutDataFileTask4V5.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

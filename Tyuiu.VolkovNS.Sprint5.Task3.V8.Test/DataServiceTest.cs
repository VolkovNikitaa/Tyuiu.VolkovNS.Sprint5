using Tyuiu.VolkovNS.Sprint5.Task3.V8.Lib;

namespace Tyuiu.VolkovNS.Sprint5.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

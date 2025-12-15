using Tyuiu.FendelNS.Sprint5.Task4.V1.Lib;
namespace Tyuiu.FendelNS.Sprint5.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V1.txt");
            FileInfo fileInfo = new FileInfo(path);
            double wait = -3.680;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}

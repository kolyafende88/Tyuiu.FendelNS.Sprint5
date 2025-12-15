using Tyuiu.FendelNS.Sprint5.Task1.V21.Lib;
namespace Tyuiu.FendelNS.Sprint5.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\HONOR\AppData\Local\Temp\tmpa4x45a.tmp";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}
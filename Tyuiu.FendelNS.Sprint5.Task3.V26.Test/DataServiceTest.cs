using Tyuiu.FendelNS.Sprint5.Task3.V26.Lib;
namespace Tyuiu.FendelNS.Sprint5.Task3.V26.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            int x = 2;
            double result = Math.Round((0.7 * (Math.Pow(x, 3))) + (1.52 * (Math.Pow(x, 2))), 3);
            double wait = 11.68;
            Assert.AreEqual(wait, result);
        }
    }
}
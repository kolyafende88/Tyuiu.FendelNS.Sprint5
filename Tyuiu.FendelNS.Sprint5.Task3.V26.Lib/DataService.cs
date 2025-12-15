using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FendelNS.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {

        public string SaveToFileTextData(int x)
        {
            double calculation = Math.Round((0.7 * (Math.Pow(x, 3))) + (1.52 * (Math.Pow(x, 2))), 3);
            byte[] byteArray = BitConverter.GetBytes(calculation);
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllBytes(tempFilePath, byteArray);
            return tempFilePath;
        }
    }
}
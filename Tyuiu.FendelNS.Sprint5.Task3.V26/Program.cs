using Tyuiu.FendelNS.Sprint5.Task3.V26.Lib;
namespace Tyuiu.FendelNS.Sprint5.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фендель Н. С. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Потоковый метод записи данных в бинарный файл                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Фендель Николай Сергеевич | СМАРТБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дано выражение , вычислить его значение при x = 2, результат сохранить в *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трё*");
            Console.WriteLine("*ёх знаков после запятой.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var result = ds.SaveToFileTextData(2);
            string filePath = "OutPutFileTask3.bin";
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create))) ;
            File.WriteAllText(filePath, result.ToString());
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
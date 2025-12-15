using Tyuiu.FendelNS.Sprint5.Task1.V21.Lib;
namespace Tyuiu.FendelNS.Sprint5.Task1.V21;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Фендель Н.С. | СМАРТБ-24-1                         ";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Фендель Николай Сергеевич | СМАРТБ-24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция (2*x-3) / (cos(x)-2*x) + 5 * x - sin(x)                    *");
        Console.WriteLine("* Произвести табулирование на диапозоне [-5;5].                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = dataService.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}

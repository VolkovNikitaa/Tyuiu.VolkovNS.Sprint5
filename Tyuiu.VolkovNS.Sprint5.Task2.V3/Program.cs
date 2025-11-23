using Tyuiu.VolkovNS.Sprint5.Task2.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл                  *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 3 на 3 элементов,заполненный*");
        Console.WriteLine("значениями с клавиатуры. Заменить нечетные элементы массива на 0.          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: \r\n\r\n5; 9; 1\r\n\r\n1; 3; 9\r\n\r\n1; 2; 2           ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = new int[3, 3] { { 5, 9, 1 }, { 1, 3, 9 }, { 1, 2, 2 } };
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан!");
    }
}
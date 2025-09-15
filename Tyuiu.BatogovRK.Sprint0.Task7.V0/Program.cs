using Tyuiu.BatogovRK.Sprint0.Task7.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #0 | Выполнил: Батогов Р. К. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант 0                                                               *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");


        int[] ArrayNums1 = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Значение элементов массива №1");
        for (int i = 0; i < ArrayNums1.Length; i++)
        {
            Console.Write(ArrayNums1[i] + ",");

        }

        Console.WriteLine();
        int[] ArrayNums2 = { 1, 2,3,4,5 };
        Console.WriteLine("Значение элементов массива №2");
        for (int i = 0; i < ArrayNums2.Length; i++)
        {
            Console.Write(ArrayNums2[i] + ",");
        }
        Console.WriteLine();

        Console.WriteLine("Результат");
        if (ArrayNums1.Length == ArrayNums2.Length)
        {
            int[] resultArray = DataService.AddArrays(ArrayNums2, ArrayNums1);
            Console.WriteLine("Сумма элементов массивов равна:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + ",");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
        }
        Console.ReadKey();
    }
}
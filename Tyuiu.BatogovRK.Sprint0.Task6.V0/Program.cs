using Tyuiu.BatogovRK.Sprint0.Task6.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numsArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Сумма элементова массива = " +DataService.AdditionArray(numsArray));
        Console.WriteLine("Разность элементов массива = " +DataService.SubstractionArray(numsArray));
        Console.WriteLine("Произведение элементов массива = " +DataService.MultArray(numsArray));
        Console.ReadKey();

    }
}
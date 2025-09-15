using System.Net.NetworkInformation;

namespace Tyuiu.BatogovRK.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static double Division(int a, int b)
        {
            if (b==0)
            {
                Console.WriteLine("Переменная b={0} на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}

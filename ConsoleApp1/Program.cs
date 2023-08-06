using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 100, 26, 10, 99, 523 };
            int[] array2 = array.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(", ", array2));
        }
    }
}

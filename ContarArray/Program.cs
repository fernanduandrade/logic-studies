using System;
using System.Linq;

namespace ContarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int resultado = array.Count();
            
            Console.WriteLine("A lista possui " + 6 + " elementos");
        }
    }
}

using System.Linq;
using System;

namespace MaiorValorEmArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9};
            int resultado = array.Max();

            Console.WriteLine("O maior elemento da lista é " + resultado); // 9
        }
    }
}

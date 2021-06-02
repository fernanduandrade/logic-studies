using System;

namespace AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio: ");

            double raio = double.Parse(Console.ReadLine());
            double raioAoQuadrado = Math.Pow(raio, 2);
            double resultado = pi * raioAoQuadrado;

            Console.WriteLine(resultado);

        }
    }
}

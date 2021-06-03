using System;

namespace Bhaskaracharya
{
    class Program
    {
        static void Main(string[] args)
        {
            int coeficienteA = int.Parse(args[0]);
            int coeficienteB = int.Parse(args[1]);
            int coeficienteC = int.Parse(args[2]);

            Bhaskara bhaskara = new Bhaskara(coeficienteA, coeficienteB, coeficienteC);
            int delta = bhaskara.discritante();

            int[] output = (delta >= 0) ? bhaskara.calcularRaizaes(delta) : bhaskara.resultadoNegativo(delta);
        
            Console.WriteLine(string.Join(",", output));
            Console.WriteLine(delta);
        }
    }
}

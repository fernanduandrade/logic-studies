using System;

namespace Logic
{
    public class Main
    {
        static void Main(string[] args)
        {
            int numero;
            string opcao;


            Console.WriteLine("Bem Vindo");
            Console.ReadLine();

            Console.Write("Escolha um número para o calculo: ");
            numero = Int32.Parse(Console.ReadLine());

            Console.Write("Digite 1 para realizar a soma, 2 para realizar o fatorail: ");
            opcao = Console.ReadLine();
            
            try 
            {
                if(opcao == "1")
                {
                    var resultado = Soma(numero);
                    Console.Write("O resultado da soma é igual a: " + resultado);
                }
                else if(opcao == "2")
                {
                    var resultado = Fatorial(numero);
                    Console.Write("O resutaldo do fatorial é igual a: " + resultado);
                }
            }
            catch (Exception err) 
            {
                Console.WriteLine("Algo deu errado.");
                Console.WriteLine(err.Message);
            }
        
        }

        public static int Fatorial(int numero)
        {
            if(numero <= 1)
            {
                return 1;
            }
            else
            {
                var resultado = numero * Fatorial(numero -1);
                return resultado;
            }
        }

        public static int Soma(int numero)
        {
            int soma = 1;

            for(int i =1; i <= numero; i++)
            {
                soma = soma + i;
            }

            return soma;
        } 
        
    }
}

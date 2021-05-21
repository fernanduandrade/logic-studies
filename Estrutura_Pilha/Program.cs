using System;

namespace Estrutura_Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.Empilhar(1);
            pilha.Empilhar(10);
            pilha.Empilhar(100);

            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());
        }
    }
}

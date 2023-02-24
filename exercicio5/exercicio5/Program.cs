using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 5
            //Crie um programa que seja capaz de apresentar uma figura similar à apresentada abaixo.
            //O usuário entrará somente com o número de linhas e o caracterea ser utilizado na apresentação final.No exemplo,
            //o número de linhas foi 5 e o caracterefoi o asterisco.
            //*
            //**
            //***
            //****
            //*****

            //quero os 125 primeiros numeros que sao divisiveis por 5
            Console.WriteLine("** EXERCICIO 5 ** ");
            Console.WriteLine();

            Console.WriteLine("Informe a quantidade de linhas que deseja: ");
            int qtd = int.Parse(Console.ReadLine());

            //quantidade de linhas
            for (int i = 0; i <= qtd; i++)
            {
                //IMPRIME NA TELA A QUANTIDADE DO INDICE DO LAÇO ATUAL
                for(int j = 0; j < i; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Fim !!!");
            Console.ReadLine();
        }
    }
}

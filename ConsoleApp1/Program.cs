using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do {
                Console.WriteLine("1-Exercício 1");
                Console.WriteLine("2-Exercício 2");
                Console.WriteLine("3-Exercício 3");
                Console.WriteLine("4-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1: ex1(); break;
                    case 2: ex2(); break;
                    case 3: ex3(); break;
                    default: Console.WriteLine("Opção inválida"); break;
                     
                }



            } while (opcao < 4);
                
               

                    
        }
        static void ex1()
        {
            int[] vetor = new int[5];
              for(int col=0;col <5; col++)
            {
                vetor[col] = int.Parse(Console.ReadLine());
            }  

        }
        static void ex2()
        {

        }
        static void ex3()
        {

        }
    }
}

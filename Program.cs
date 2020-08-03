using System;
using System.Linq;

namespace exercicio_logica_programacao7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empilhar números e invertê-los de posição

            //Construa uma função que irá preencher um Array com 10 números informados pelo usuário. Tome todas as precauções 
            //para que o usuário não informe uma letra, ele deverá informar apenas um número INTEIRO.

            //Construa uma outra função que irá ler as 10 posições de forma decrescente e que imprima estes números nesta ordem.

            int[] pilha = new int[10];
            string varInf;
            int p = 0;
            while (p < 10)
            {
                Console.WriteLine($"Favor informar valor da posição : {p}");
                varInf = Console.ReadLine();
                if (varInf.All(char.IsDigit))
                {
                    pilha[p] = Convert.ToInt32(varInf);
                    p++;
                }

                else
                    Console.WriteLine($"Favor informar somente números.");
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"Posição {i} ::: valor> {pilha[i]} .");
            }
        }
    }
}

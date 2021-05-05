using System;

namespace Atividade_de_0_a_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numeroValido = false;
            do
            {
                Console.WriteLine("Insira um número entre 0 a 10: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero <= 10 &&  numero >= 0)
                {
                    numeroValido = true;
                    Console.WriteLine("Esse Número é Válido!");
                    Console.WriteLine("Fim da Execução!");
                }
                else
                {
                    Console.WriteLine("Número Inválido");
                }
            } while (numeroValido == false);

        }
    }
}

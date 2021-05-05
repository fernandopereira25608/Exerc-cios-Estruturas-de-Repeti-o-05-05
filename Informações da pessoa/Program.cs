using System;

namespace Informações_da_pessoa
{
    class Program
    {
        static void Main(string[] args)

        {
         string nome; 
         bool validacãoNome = false;   
        do
        {
            Console.WriteLine("Digite seu Nome: ");
            string Nome = Console.ReadLine();

            if (Nome == "")
            {
                Console.WriteLine("ERRO, Nenhum Nome Insirido! Digite seu Nome: ");
                Nome = Console.ReadLine();
            }

                Console.WriteLine("Digite sua idade: ");
                string  idade = Console.ReadLine();

                Console.WriteLine("Digite seu Sálario: ");
                string salario = Console.ReadLine();


        } while (!string.IsNullOrEmpty(Nome));
           

        }
    }
}
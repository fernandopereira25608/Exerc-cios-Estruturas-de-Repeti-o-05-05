using System;

namespace Atividade_Usuario_e_Senha
{
    class Program
    {
        static void Main(string[] args)


        {
            bool respostaCorreta = false;

            do
            {
                Console.WriteLine("Digite seu nome de Usuário");
                string respostaUsuario = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                string respostaSenha = Console.ReadLine();

                if ((respostaUsuario == respostaSenha) || respostaSenha.Length < 10)
                {

                    do
                    {
                        Console.WriteLine("ERRO: Seu usuário e sua senha são inválidos, digite outra senha!");
                        respostaSenha = Console.ReadLine();

                    } while ((respostaUsuario == respostaSenha) || respostaSenha.Length < 10);

                }

                respostaCorreta = true;

                Console.WriteLine("Parabéns, seu Usuário e senha estão corretas! ");

            } while (respostaCorreta == false);

        }
    }
}

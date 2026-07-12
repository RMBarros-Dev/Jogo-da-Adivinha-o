using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                // Criamos um novo objeto Partida
                Partida partida = new Partida();

                // Pedimos para o objeto executar a sua lógica
                partida.Jogar();

                Console.Write("\nDeseja jogar novamente? (S/N): ");
                string resposta = Console.ReadLine();

                // Verifica se o usuário quer sair
                jogarNovamente = (resposta.ToUpper() == "S");
            }

            Console.WriteLine("Obrigado por jogar!");
        }
    }
}
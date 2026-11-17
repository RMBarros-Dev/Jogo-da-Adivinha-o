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

                while (true)
                {
                    Console.Write("\nDeseja jogar novamente? (S/N): ");
                    string? resposta = Console.ReadLine();

                    // EOF encerra o programa sem repetir a pergunta indefinidamente.
                    if (resposta is null)
                    {
                        jogarNovamente = false;
                        break;
                    }

                    if (RegrasDaPartida.TryInterpretarRespostaJogarNovamente(
                        resposta,
                        out jogarNovamente))
                    {
                        break;
                    }

                    Console.WriteLine("Resposta inválida. Digite S para sim ou N para não.");
                }
            }

            Console.WriteLine("Obrigado por jogar!");
        }
    }
}
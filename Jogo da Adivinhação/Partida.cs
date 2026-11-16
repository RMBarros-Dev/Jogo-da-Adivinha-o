using System;

namespace JogoAdivinhacao
{
    public class Partida
    {
        // Propriedades privadas: apenas a classe Partida tem acesso a esses dados
        private int _numeroSecreto;
        private int _maxTentativas = 5;

        // Construtor: inicializa a partida assim que você cria o objeto
        public Partida(Random? random = null)
        {
            _numeroSecreto = (random ?? Random.Shared).Next(1, 101);
        }

        // Método principal que controla o fluxo da partida
        public void Jogar()
        {
            int contador = 0;
            bool acertou = false;

            Console.WriteLine("--- NOVA PARTIDA INICIADA ---");

            while (contador < _maxTentativas && !acertou)
            {
                Console.Write($"Tentativa {contador + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int palpite))
                {
                    if (palpite is < 1 or > 100)
                    {
                        Console.WriteLine("Digite um número entre 1 e 100. Esta entrada não consome uma tentativa.");
                        continue;
                    }

                    contador++;
                    acertou = Verificar(palpite);
                }
                else
                {
                    Console.WriteLine("Erro: Digite apenas números inteiros.");
                }
            }

            if (!acertou)
                Console.WriteLine($"Game Over! O número era {_numeroSecreto}.");
        }

        // Mantém a interação no console e delega a regra pura para permitir testes determinísticos.
        private bool Verificar(int palpite)
        {
            var resultado = RegrasDaPartida.AvaliarPalpite(_numeroSecreto, palpite);

            switch (resultado)
            {
                case ResultadoPalpite.Menor:
                    Console.WriteLine("Dica: O número é MAIOR.");
                    return false;
                case ResultadoPalpite.Maior:
                    Console.WriteLine("Dica: O número é MENOR.");
                    return false;
                default:
                    Console.WriteLine("Parabéns! Você acertou!");
                    return true;
            }
        }
    }
}
using System;

namespace JogoAdivinhacao
{
    public class Partida
    {
        // Propriedades privadas: apenas a classe Partida tem acesso a esses dados
        private int _numeroSecreto;
        private int _maxTentativas = 5;

        // Construtor: inicializa a partida assim que você cria o objeto
        public Partida()
        {
            Random random = new Random();
            _numeroSecreto = random.Next(1, 101);
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

        // Método de apoio (privado) para verificar o palpite
        private bool Verificar(int palpite)
        {
            if (palpite < _numeroSecreto)
            {
                Console.WriteLine("Dica: O número é MAIOR.");
            }
            else if (palpite > _numeroSecreto)
            {
                Console.WriteLine("Dica: O número é MENOR.");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou!");
                return true;
            }
            return false;
        }
    }
}
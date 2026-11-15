namespace JogoAdivinhacao;

public enum ResultadoPalpite
{
    Menor,
    Maior,
    Correto
}

public static class RegrasDaPartida
{
    public static ResultadoPalpite AvaliarPalpite(int numeroSecreto, int palpite)
    {
        if (numeroSecreto is < 1 or > 100)
            throw new ArgumentOutOfRangeException(nameof(numeroSecreto), "O número secreto deve estar entre 1 e 100.");

        if (palpite < numeroSecreto)
            return ResultadoPalpite.Menor;

        if (palpite > numeroSecreto)
            return ResultadoPalpite.Maior;

        return ResultadoPalpite.Correto;
    }
}

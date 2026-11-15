using JogoAdivinhacao;
using Xunit;

namespace JogoDaAdivinhacao.Tests;

public class RegrasDaPartidaTests
{
    [Fact]
    public void AvaliarPalpite_RetornaMenorQuandoPalpiteEstaAbaixoDoNumeroSecreto()
    {
        var resultado = RegrasDaPartida.AvaliarPalpite(50, 25);
        Assert.Equal(ResultadoPalpite.Menor, resultado);
    }

    [Fact]
    public void AvaliarPalpite_RetornaMaiorQuandoPalpiteEstaAcimaDoNumeroSecreto()
    {
        var resultado = RegrasDaPartida.AvaliarPalpite(50, 75);
        Assert.Equal(ResultadoPalpite.Maior, resultado);
    }

    [Fact]
    public void AvaliarPalpite_RetornaCorretoQuandoPalpiteCoincide()
    {
        var resultado = RegrasDaPartida.AvaliarPalpite(50, 50);
        Assert.Equal(ResultadoPalpite.Correto, resultado);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public void AvaliarPalpite_RejeitaNumeroSecretoForaDoIntervalo(int numeroSecreto)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => RegrasDaPartida.AvaliarPalpite(numeroSecreto, 50));
    }
}

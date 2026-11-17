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

    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public void AvaliarPalpite_RejeitaPalpiteForaDoIntervalo(int palpite)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => RegrasDaPartida.AvaliarPalpite(50, palpite));
    }

    [Theory]
    [InlineData("S", true)]
    [InlineData("s", true)]
    [InlineData(" S ", true)]
    [InlineData("N", false)]
    [InlineData("n", false)]
    [InlineData(" N ", false)]
    public void TryInterpretarRespostaJogarNovamente_AceitaRespostasValidas(
        string resposta,
        bool esperado)
    {
        var valido = RegrasDaPartida.TryInterpretarRespostaJogarNovamente(
            resposta,
            out var jogarNovamente);

        Assert.True(valido);
        Assert.Equal(esperado, jogarNovamente);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("talvez")]
    [InlineData("sim")]
    [InlineData("não")]
    [InlineData("X")]
    public void TryInterpretarRespostaJogarNovamente_RejeitaRespostasInvalidas(
        string resposta)
    {
        var valido = RegrasDaPartida.TryInterpretarRespostaJogarNovamente(
            resposta,
            out var jogarNovamente);

        Assert.False(valido);
        Assert.False(jogarNovamente);
    }

    [Fact]
    public void TryInterpretarRespostaJogarNovamente_RejeitaValorNulo()
    {
        var valido = RegrasDaPartida.TryInterpretarRespostaJogarNovamente(
            null,
            out var jogarNovamente);

        Assert.False(valido);
        Assert.False(jogarNovamente);
    }
}

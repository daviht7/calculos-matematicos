namespace CalculosMatematicos.Tests;

public class CalculadoraTests
{
    [Fact]
    public void DeveExecutarOperacoesBasicas()
    {
        Assert.Equal(10m, Calculadora.Somar(7m, 3m));
        Assert.Equal(4m, Calculadora.Subtrair(7m, 3m));
        Assert.Equal(21m, Calculadora.Multiplicar(7m, 3m));
        Assert.Equal(7m / 3m, Calculadora.Dividir(7m, 3m));
    }

    [Fact]
    public void DeveCalcularPotenciaRaizEPercentual()
    {
        Assert.Equal(8, Calculadora.Potencia(2, 3));
        Assert.Equal(3, Calculadora.RaizQuadrada(9));
        Assert.Equal(25m, Calculadora.CalcularPercentual(200m, 12.5m));
    }

    [Fact]
    public void DeveEncontrarMaiorNumeroEntreCincoValores()
    {
        Assert.Equal(12m, Calculadora.EncontrarMaior(4m, 12m, 7m, 2m, 9m));
    }

    [Fact]
    public void DeveEncontrarMenorNumeroEntreDezValores()
    {
        Assert.Equal(-3m, Calculadora.EncontrarMenor(4m, 12m, 7m, 2m, 9m, 0m, 15m, -3m, 8m, 1m));
    }

    [Fact]
    public void DeveImpedirDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => Calculadora.Dividir(10m, 0m));
    }

    [Fact]
    public void DeveImpedirRaizDeValorNegativo()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Calculadora.RaizQuadrada(-1));
    }
}

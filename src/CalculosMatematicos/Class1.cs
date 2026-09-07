namespace CalculosMatematicos;

public static class Calculadora
{
	public static decimal Somar(decimal primeiroValor, decimal segundoValor) => primeiroValor + segundoValor;

	public static decimal Subtrair(decimal primeiroValor, decimal segundoValor) => primeiroValor - segundoValor;

	public static decimal Multiplicar(decimal primeiroValor, decimal segundoValor) => primeiroValor * segundoValor;

	public static decimal Dividir(decimal dividendo, decimal divisor)
	{
		if (divisor == 0)
		{
			throw new DivideByZeroException("O divisor nao pode ser zero.");
		}

		return dividendo / divisor;
	}

	public static double Potencia(double baseNumerica, double expoente) => Math.Pow(baseNumerica, expoente);

	public static double RaizQuadrada(double valor)
	{
		if (valor < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(valor), "A raiz quadrada exige um valor nao negativo.");
		}

		return Math.Sqrt(valor);
	}

	public static decimal CalcularPercentual(decimal valor, decimal percentual) => valor * percentual / 100;
}

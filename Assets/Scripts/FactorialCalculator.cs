using System.Linq;

public sealed class FactorialCalculator
{
    public float CalculateFactorial(int number) => Enumerable.Range(1, number).Aggregate(1, (p, item) => p * item);
}
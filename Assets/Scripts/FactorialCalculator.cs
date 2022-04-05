using System.Linq;

public static class FactorialCalculator
{
    public static float CalculateFactorial(int number) => Enumerable.Range(1, number).Aggregate(1, (p, item) => p * item);
}
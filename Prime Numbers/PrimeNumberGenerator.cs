using System.Collections.Generic;

public class PrimeNumberGenerator
{
    public List<int> PrimeNumbers { get { return _primeNumbers; } }

    private List<int> _primeNumbers;
    private int _limit;

    public PrimeNumberGenerator(int limit)
    {
        this._limit = limit;
        _primeNumbers = new List<int>() { };
    }

    internal void Generate()
    {
        for (int number = 2; number <= _limit; number++)
        {
            if (isPrime(number)) _primeNumbers.Add(number);
        }
        _primeNumbers.Insert(0, 1);
    }

    private bool isPrime(int number)
    {
        var halfOfNumber = number / 2;
        foreach (var primeNumber in _primeNumbers)
        {
            if (primeNumber > halfOfNumber) break;
            if (isDivisible(number, primeNumber)) return false;
        }
        return true;
    }

    private bool isDivisible(int number, int divider) => number % divider == 0;
}
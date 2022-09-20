using System.Collections.Generic;

public class PrimeNumberGenerator
{
    public List<int> PrimeNumbers { get { return _primeNumbers; } }

    private List<int> _primeNumbers;
    private int _limit;
    private int _initialValue = 2;
    private float _half = 0.5f;
    private int _initialIndex = 0;

    public PrimeNumberGenerator(int limit)
    {
        this._limit = limit;
        _primeNumbers = new List<int>() { };
    }

    internal void Generate()
    {
        for (int number = _initialValue; number <= _limit; number++)
        {
            if (isPrime(number)) _primeNumbers.Add(number);
        }
        _primeNumbers.Insert(_initialIndex, 1);
    }

    private bool isPrime(int number)
    {
        var halfOfNumber = number * _half;

        foreach (var primeNumber in _primeNumbers)
        {
            if (primeNumber > halfOfNumber) break;
            if (isDivisible(number, primeNumber)) return false;
        }
        return true;
    }

    private bool isDivisible(int number, int divider) => number % divider == 0;
}
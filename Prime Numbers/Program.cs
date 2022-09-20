using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;
            var generator = new PrimeNumberGenerator(limit);
            generator.Generate();

            Console.WriteLine(limit + " değerine kadar olan asal sayılar:");
            foreach (var primeNumber in generator.PrimeNumbers)
                Console.WriteLine(primeNumber);
        }
    }
}

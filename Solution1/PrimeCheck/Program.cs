using System;

class IsPrime
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        uint divisor = 2;
        uint maxDivisor = (uint)Math.Sqrt(N);
        bool isPrime = true;

        while (isPrime && (divisor <= maxDivisor))
        {
            if (N % divisor == 0)
            {
                isPrime = false;
            }

            divisor++;
        }

        Console.WriteLine("Prime? {0}", isPrime);

        Console.ReadLine();
    }
}

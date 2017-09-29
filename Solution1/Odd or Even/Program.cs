using System;

namespace Odd_or_Even
{
    class OddorEven
    {
        static void Main()
        {
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("even {0}", Number);
            }

            else
            {
                Console.WriteLine("odd {0}", Number);
            }
            Console.ReadLine();
        }
    }
}

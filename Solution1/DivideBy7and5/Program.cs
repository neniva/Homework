using System;

namespace DivideBy7and5
{
    class Program
    {
        static void Main()
        {
            int Number = int.Parse(Console.ReadLine());

            if (Number % 7 == 0 && Number % 5 ==0 )
            {
                Console.WriteLine("true {0}", Number);
            }

            else
            {
                Console.WriteLine("false {0}", Number);
            }
            Console.ReadLine();
        }
    }
}

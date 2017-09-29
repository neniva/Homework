using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {


            double W = double.Parse(Console.ReadLine());
            double gravityofMoon = 0.17;
            double gravity = W * gravityofMoon;

            Console.WriteLine("{0:F3}", gravity);

            Console.ReadLine();
        }
    }
}

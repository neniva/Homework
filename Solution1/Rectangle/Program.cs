using System;


namespace Rectangle
{
    class Rectangle
    {
        static void Main()
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float area = width * height;
            float perimeter = 2*(width + height);

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    internal class LineCompare
    {
        public static void Lines()
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Enter the vlue of x : ");

            x1 = double.Parse(Console.ReadLine());

            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y : ");

            y1 = double.Parse(Console.ReadLine());

            y2 = double.Parse(Console.ReadLine());

            double length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("The length between the two point is: " + length);
        }

    }
}

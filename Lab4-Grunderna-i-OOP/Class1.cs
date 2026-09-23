using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_Grunderna_i_OOP
{
    internal class Circle
    {
        public int Radius { get; set; }
        public double Area { get; set; }
        public double Circumference { get; set; }

        public Circle(int radius)
        {
            Radius = radius;

        }
        public double GetArea()
        {
            Area = Radius * Radius * Math.PI;
            return Area;
        }

        public double GetCircumference()
        {
            Circumference = Radius * Math.PI;
            return Circumference;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Arean är {Area:F2}");
            Console.WriteLine($"Omkretsen är {Circumference:F2}");

            // Rounding the numbers to make it easeyer to look at
        }



    }

    
}

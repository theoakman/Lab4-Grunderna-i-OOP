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

        public double Volume { get; set; }

        public Circle(int radius)
        {
            Radius = radius;

        }

        // Calculates the area, circumference and volume of
        // the sphere object using the radius field
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
        public double GetVolume()
        {
            Volume = (4.0 / 3.0) * Math.PI * Radius * Radius * Radius;
            return Volume;

        }


        //Shows the calculated values (rounded to not clutter the console)
        public void DisplayStats()
        {
            Console.WriteLine($"Arean är {Area:F2}");
            Console.WriteLine($"Omkretsen är {Circumference:F2}");
            Console.WriteLine($"Volymen är {Volume}");
        }



    }

    
}

using System;
// I think I hate Triangles
public class Triangle
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }
    public double Height { get; set; }         
    public double PyramidHeight { get; set; }    
    public double Area { get; set; }
    public double Perimeter { get; set; }
    public double Volume { get; set; }

    public Triangle(int sideA, int sideB, int sideC, double height, double pyramidHeight)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        Height = height;
        PyramidHeight = pyramidHeight;

    }

    // Sida A is base and side B is h
    public double GetTriangleArea()
    {
        Area = SideA * Height / 2.0;
        return Area;
    }

    public double GetTrianglePerimeter()
    {
        Perimeter = SideA + SideB + SideC;
        return Perimeter;
    }

    public double GetTriangleVolume()
    {
        Volume = (SideA * PyramidHeight) / 3;
        return Volume;

    }

    //Shows the calculated values (rounded to not clutter the console)
    public void DisplayTriangleValues()
    {
        Console.WriteLine($"Arean är {Area:F2}");
        Console.WriteLine($"Omkretsen är {Perimeter:F2}");
        Console.WriteLine($"Volymen är {Volume}");
    }


}

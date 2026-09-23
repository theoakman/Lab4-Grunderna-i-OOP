namespace Lab4_Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle1;
            Circle circle2;
            int radius1 = 5;
            var radius2 = 6;

            circle1 = new Circle(radius1);
            circle1.GetArea();
            circle1.GetCircumference();
            circle1.GetVolume();
            circle1.DisplayStats();

            circle2 = new Circle(radius2);
            circle2.GetArea();
            circle2.GetCircumference();
            circle1.GetVolume();
            circle2.DisplayStats();


            // Hard coded values for 2 triangles / pyramids 
            // There are more values then the circle becauce
            // the math was not woth it for this assignment

            Triangle triangle1;
            var sideA1 = 5;
            var sideB1 = 5;
            var sideC1 = 5;
            var height1 = 4.3301;
            var pyramidHeight1 = 4.0825;

            Triangle triangle2;
            var sideA2 = 5;
            var sideB2 = 9;
            var sideC2 = 11;
            var height2 = 4.25;
            var pyramidHeight2 = 7.0;



            triangle1 = new Triangle(sideA1, sideB1, sideC1, height1, pyramidHeight1);
            triangle1.GetTriangleArea();
            triangle1.GetTrianglePerimeter();
            triangle1.GetTriangleVolume();
            triangle1.DisplayTriangleValues();

            triangle2 = new Triangle(sideA2, sideB2, sideC2, height2, pyramidHeight2);
            triangle2.GetTriangleArea();
            triangle2.GetTrianglePerimeter();
            triangle2.GetTriangleVolume();
            triangle2.DisplayTriangleValues();


        }
    }
}

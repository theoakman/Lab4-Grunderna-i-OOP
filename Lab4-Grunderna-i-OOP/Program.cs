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
            circle1.DisplayStats();

            circle2 = new Circle(radius2);
            circle2.GetArea();
            circle2.GetCircumference();
            circle2.DisplayStats();


        }
    }
}

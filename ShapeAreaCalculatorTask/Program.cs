namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("enter the shape you wish");
            string shape = Console.Readline();
            int CircleArea = 0
            int TriArea = 0
            int RecArea = 0
            int PenArea = 0
            int OcArea = 0
            if (shape == "Circle")
            {
                Console.Writeline("enter the radius");
                int Radius = Convert.Toint32(Console.Readline());
                CircleArea = Radius * Radius * 3.14
                Console.Writeline(CircleArea);
            }
            Elseif (shape == "triangle")
            {
                Console.Writeline("enter the height of the triangle");
                int Height = Convert.Toint32(Console.Readline());
                Console.Writeline("enter the base of the triangle");
                int Base = Convert.Toint32(Console.Readline());
                TriArea = 0.5 * Height * Base;
            }
            Elseif (shape == "Rectangle")
            {
                Console.Writeline("enter the length of the rectangle")
                int Length = Convert.Toint32(Console.Readline());
                Console.Writeline("enter the width of the rectangle");
                int Width = Convert.ToInt32(Console.Readline());
                RecArea = Length * Width
            }
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon
        }
        static int areaOfRectangle()//Add the parameters
        {

        }
    }
}

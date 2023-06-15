namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            do 
            {
                Console.WriteLine("What shape would you like to model?");
                Console.WriteLine("1 for Circle, 2 for Rectangle, 3 for Triangle");
                String input = Console.ReadLine();

                while (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please don't ignore me :(");
                    input = Console.ReadLine();
                }

                while (!input.All(char.IsDigit))
                {
                    Console.WriteLine("That is not a number doofus");
                    input = Console.ReadLine();
                }

                if(input == "1")
                {
                    Console.WriteLine("Cool, you picked circle");
                    Console.WriteLine("Input the radius of this circle in cm:");
                    String radius = Console.ReadLine();

                    while (!radius.All(char.IsDigit))
                    {
                        Console.WriteLine("That is not a number doofus");
                        radius = Console.ReadLine();
                    }
                    double rad = double.Parse(radius);
                    Circle c = new Circle(rad);
                    double Area = c.Area();
                    double Perim = c.Perimeter();

                    Console.WriteLine("This circle has an area of {0}cm^2 and a perimeter of {1}cm\n", Area, Perim);
                }
                else if (input == "2") 
                {
                    Console.WriteLine("Cool, you picked rectangle");
                    Console.WriteLine("Input the height of this rectangle in cm:");
                    String height = Console.ReadLine();

                    while (!height.All(char.IsDigit))
                    {
                        Console.WriteLine("That is not a number doofus");
                        height = Console.ReadLine();
                    }
                    double h = double.Parse(height);

                    Console.WriteLine("Input the height of this rectangle in cm:");
                    String width = Console.ReadLine();

                    while (!width.All(char.IsDigit))
                    {
                        Console.WriteLine("That is not a number doofus");
                        width = Console.ReadLine();
                    }
                    double w = double.Parse(width);

                    Rectangle r = new Rectangle(h, w);

                    double Area = r.Area();
                    double Perim = r.Perimeter();

                    Console.WriteLine("This rectangle has an area of {0}cm^2 and a perimeter of {1}cm\n", Area, Perim);

                }
                else if (input == "3")
                {
                    Console.WriteLine("Cool, you picked rectangle");
                    Console.WriteLine("Input the the first side of this triangle in cm:");
                    String SideA = Console.ReadLine();

                    while (!SideA.All(char.IsDigit))
                    {
                        Console.WriteLine("That is not a number doofus");
                        SideA = Console.ReadLine();
                    }
                    double A = double.Parse(SideA);

                    Console.WriteLine("Input the second side of this rectangle in cm:");
                    String SideB = Console.ReadLine();

                    while (!SideB.All(char.IsDigit))
                    {
                        Console.WriteLine("That is not a number doofus");
                        SideB = Console.ReadLine();
                    }
                    double B = double.Parse(SideB);

                    Console.WriteLine("Input the last side of this rectangle in cm:");
                    String SideC = Console.ReadLine();

                    while (!SideC.All(char.IsDigit))
                    {
                        Console.WriteLine("That is not a number doofus");
                        SideC = Console.ReadLine();
                    }
                    double C = double.Parse(SideC);

                    Triangle t = new Triangle(A, B, C);

                    double Area = t.Area();
                    double Perim = t.Perimeter();

                    Console.WriteLine("This triangle has an area of {0}cm^2 and a perimeter of {1}cm\n", Area, Perim);
                }
                else
                {
                    Console.WriteLine("That is none of the numbers i gave you >:(, I am leaving");
                    quit = true;
                }


            } while (!quit);    
        }
    }
}
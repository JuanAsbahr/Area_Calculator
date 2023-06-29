using System;
using Area_Calculator.Entities.Enums;
using System.Collections;
using Area_Calculator.Entities;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        Console.WriteLine("Enter the number of Shapes: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Shape #{i} data");
            Console.Write("Rectangle or Circle (r/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (ch == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());

                list.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine());
                list.Add(new Circle(radius, color));
            }
            Console.WriteLine();
        }
        Console.WriteLine("SHAPE AREAS: ");
        foreach (Shape shape in list)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
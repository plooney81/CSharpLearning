using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        static void CalculateTotalCost()
        {
            double tileCost = 180;
            double totalArea = Rectangle(1500, 2500) + (Circle(375)/2) + Triangle(750, 500);
            double totalCostInPesos = Math.Round(totalArea * tileCost, 2);
            Console.WriteLine($" The total cost in pesos for the tile in the Teotihuacan is {totalCostInPesos} pesos");
        }
        static double Rectangle(double length = 0, double width = 0)
        {
            return length * width;
        }

        static double Circle(double radius = 0)
        {
            return Math.PI * (Math.Pow(radius, 2.0));
        }

        static double Triangle(double bottom = 0, double height = 0)
        {
            return 0.5 * bottom * height;
        }
    }
}

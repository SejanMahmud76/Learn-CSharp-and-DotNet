using System;

class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("Choose 1. Fahrebheit to Celsious");
        Console.WriteLine("Choose 2. Celsious to Fahrebheit ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter your Fahrenheit Temperature:");
                double Fahrebheit = Convert.ToDouble(Console.ReadLine());
                double Celsious = (Fahrebheit - 32) / 1.8;
                Console.WriteLine($"Temperature in Celcious{Celsious:F2}");
                break;

            case 2:
                Console.Write("Enter your Celsious Temperature");

                double cels = Convert.ToDouble(Console.ReadLine());
                double fahren = (cels * 1.8 + 32);
                Console.WriteLine($"Temperature in Fahrenhit{fahren:F2}");
                break;

            default:
                Console.WriteLine("Invalid Coice");
                break;
        }
    }
}
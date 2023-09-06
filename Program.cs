// See https://aka.ms/new-console-template for more information
// Module 2 Excercise 2.1.1 
// Inches to Centimeters Interactive 
// Addison Roy

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("simple inches to centimters like magic");
        Console.Write("Enter a number in inches: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double inches))
        {
            double centimeters = inches * 2.54;

            Console.WriteLine($"Inches = {inches}");
            Console.WriteLine($"Centimeters = {centimeters}");
        }
        else
        {
            Console.WriteLine("Enter a damn number :)");
        }
    }
}


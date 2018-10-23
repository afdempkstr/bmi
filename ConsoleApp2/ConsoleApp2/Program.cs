using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give your weight:");
            string w = Console.ReadLine();
            float weight = float.Parse(w);
            float height = 1.8f; 
            float bmi = weight/ (height * height);
            // Console.WriteLine prints something to the console
            Console.WriteLine($"BMI is: {bmi}");
            Console.Read();
        }
    }
}

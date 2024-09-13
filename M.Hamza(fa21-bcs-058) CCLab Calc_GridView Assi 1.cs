using System;
class ScientificCalculator
{
    static void Main(string[] args)
    {
        bool Calc = true;

        while (Calc)
        {
            Console.WriteLine("Scientific Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1: Sine (sin)");
            Console.WriteLine("2: Cosine (cos)");
            Console.WriteLine("3: Tangent (tan)");
            Console.WriteLine("4: Logarithm (log base 10)");
            Console.WriteLine("5: Exit");
            
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 5)
            {
                Calc = false;
                break;
            }
            
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Math.Sin(input);
                    Console.WriteLine($"sin({input}) = {result}");
                    break;
                case 2:
                    result = Math.Cos(input);
                    Console.WriteLine($"cos({input}) = {result}");
                    break;
                case 3:
                    result = Math.Tan(input);
                    Console.WriteLine($"tan({input}) = {result}");
                    break;
                case 4:
                    result = Math.Log10(input);
                    Console.WriteLine($"log10({input}) = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }

            Console.WriteLine(); // Blank line for spacing
        }
        
        Console.WriteLine("Calculator exited.");
    }
}

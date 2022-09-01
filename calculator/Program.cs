using System;

namespace calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculator");
            Console.WriteLine("Please, choice one that options at down:");
            Console.WriteLine("1 - Sum:");
            Console.WriteLine("2 - Subtraction:");
            Console.WriteLine("3 - Multiplication:");
            Console.WriteLine("4 - Division:");
            Console.WriteLine("5 - Potentiation:");
            Console.WriteLine("6 - Square Root:");
            Console.WriteLine("7 - Cubic Root:");
            Console.WriteLine("0 - Exit:");
            Console.WriteLine(" ");
            Console.Write("Choice: ");
            
            short options = short.Parse(Console.ReadLine());

            switch(options)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: Potentiation(); break;
                case 6: SquareRoot(); break;
                case 7: CubicRoot(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

            Console.ReadKey();
        }

        static void Sum()
        {
            Console.Clear();
            
            Console.WriteLine("Chosen Sum");
            Console.WriteLine("----------");

            Console.Write("Please, insert the first value: ");
            double value1 = double.Parse(Console.ReadLine()); 

            Console.Write("Thank you, now insert the second value: ");
            double value2 = double.Parse(Console.ReadLine());

            double toSum = value1 + value2;

            Console.WriteLine($"The Sum of {value1} more {value2} is equal to: {toSum}");
            
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Chosen 2 - Subtraction");
            Console.WriteLine("----------------------");
            
            Console.Write("Please, insert the first value: ");
            double value1 = double.Parse(Console.ReadLine()); 

            Console.Write("Thank you, now insert the second value: ");
            double value2 = double.Parse(Console.ReadLine());

            double toSubtracted = value1 - value2;
            Console.WriteLine($"The value {value1} subtracted by {value2} is equal to: {toSubtracted}");
            
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            
            Console.WriteLine("Chosen 3 - Multiplication");
            Console.WriteLine("-------------------------");

            Console.Write("Please, insert the first value: ");
            double value1 = double.Parse(Console.ReadLine()); 

            Console.Write("Thank you, now insert the second value: ");
            double value2 = double.Parse(Console.ReadLine());

            double toMultiplication = value1 * value2;
            Console.WriteLine($"The value {value1} multiplicated by {value2} is equal to: {toMultiplication}");
            
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            
            Console.WriteLine("Chosen 4 - Division");
            Console.WriteLine("-------------------");

            Console.Write("Please, insert the first value: ");
            double value1 = double.Parse(Console.ReadLine()); 

            Console.Write("Thank you, now insert the second value: ");
            double value2 = double.Parse(Console.ReadLine());

            double toDivision = value1 / value2;
            Console.WriteLine($"The value {value1} divided by {value2} is equal to: {toDivision}");
            
            Console.ReadKey();
            Menu();
        }

        static void Potentiation()
        {
            Console.Clear();
            
            Console.WriteLine("Chosen 5 - Potentiation");
            Console.WriteLine("-----------------------");

            Console.Write("Please, insert the base value: ");
            double value1 = double.Parse(Console.ReadLine()); 

            Console.Write("Potency value: ");
            double value2 = double.Parse(Console.ReadLine());

            double elevated = Math.Pow(value1, value2);
            Console.WriteLine($"The value {value1} raised to {value2} is equal to: {elevated}");
            
            Console.ReadKey();
            Menu();
        }

        static void SquareRoot()
        {
            Console.Clear();
            
            Console.WriteLine("Chosen 6 - Square Root");
            Console.WriteLine("----------------------");

            Console.Write("Please, insert the value to obtain their Square Root: ");
            double value1 = double.Parse(Console.ReadLine()); 

            double toSquareRoot = Math.Sqrt(value1);
            
            Console.WriteLine($"The Square Root of {value1} is: {toSquareRoot}");

            Console.ReadKey();
            Menu();
        }

        static void CubicRoot()
        {
            Console.Clear();
            
            Console.WriteLine("Chosen 7 - Cubic Root");
            Console.WriteLine("---------------------");

            Console.Write("Please, insert the value to obtain their Cubic Root: ");
            double value1 = double.Parse(Console.ReadLine()); 

            double toCubicRoot = Math.Cbrt(value1);
            Console.WriteLine($"The Cubic Root of {value1} is: {toCubicRoot}");
            
            Console.ReadKey();
            Menu();
        }
    }
}

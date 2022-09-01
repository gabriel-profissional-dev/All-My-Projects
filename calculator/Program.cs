using System;

namespace calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            
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
            int opcao = int.Parse(Console.ReadLine());
        }
    }
}



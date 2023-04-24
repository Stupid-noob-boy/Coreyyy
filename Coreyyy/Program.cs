using System;
using CalculationLib;
namespace Coreyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение:");
            Console.WriteLine(CalculationLib.Castle1.Plus());
            Console.WriteLine("");
            Console.WriteLine("Вычитание:");
            Console.WriteLine(CalculationLib.Castle1.Minus());
            Console.WriteLine("");
            Console.WriteLine("Умножение:");
            Console.WriteLine(CalculationLib.Castle1.Multiplication());
            Console.WriteLine("");
            Console.WriteLine("Деление:");
            Console.WriteLine(CalculationLib.Castle1.Division());
        }
    }
}

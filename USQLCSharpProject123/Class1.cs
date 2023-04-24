using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CalculationLib
{
    public static class Castle1
    {
       public static double Plus()
        {
           double a = Convert.ToDouble(Console.ReadLine());
           double b = Convert.ToDouble(Console.ReadLine());
            return a + b;
        }
        public static double Minus()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            return a - b;
        }
        public static double Multiplication()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            return a * b;
        }
        public static double Division()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            return a / b;
        }
    }
}
using System;
using System.Collections.Generic;
using StringTransmutations;

namespace StringToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            double num = StringToNumber.StrToDouble(input);
            Console.WriteLine(num);
        }
    }
}

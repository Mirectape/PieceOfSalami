using System;
using System.Collections.Generic;

namespace StringToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            double num = StrToDouble(input);
            Console.WriteLine(num);
        }

        static char[] StrToChars(string s)
        {
            char[] chars = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                chars[i] = s[i];
            }
            return chars;
        }

        static int StrToInt(string s)
        {
            char[] chars = StrToChars(s);
            int temp = 0; 
            int i = 0;
            int sign = 0; // 0 if plus, 1 if minus 

            if (chars[i] == '-')
            {
                sign = 1;
                i++;
            }

            while (chars[i] >= 0x30 && chars[i] <= 0x39)
            {
                temp = temp + (chars[i] & 0x0F);
                temp = temp * 10;
                i++;
                if (i >= chars.Length) break;
            } 
            temp = temp / 10;

            if (sign == 1)
            {
                temp = -temp;
            }
            return (temp);
        }

        static double StrToDouble(string s)
        {
            char[] chars = StrToChars(s);
            double intPart = 0;
            double decimalPart = 0;
            int i = 0; //index for chars
            int sign = 0; // 0 if plus, 1 if minus 

            if (chars[i] == '-')
            {
                sign = 1;
                i++;
            }
            else if (chars[i] == '+')
            {
                i++;
            }
            else if (chars[i] >= 0x30 && chars[i] <= 0x39)
            {
                intPart = intPart + (chars[i] & 0x0F);
                intPart = intPart * 10;
                i++;
            }
            else
            {
                throw new ImproperSymbolException();
            }

            while(i < chars.Length)
            {
                if (chars[i] == 0x2E || chars[i] == 0x2C)
                {
                    i++; //thus we go to the decimal part
                    break;
                }
                else if(chars[i] >= 0x30 && chars[i] <= 0x39)
                {
                    intPart = intPart + (chars[i] & 0x0F);
                    intPart = intPart * 10;
                    i++;
                    if (i >= chars.Length) break;
                }
                else
                {
                    throw new ImproperSymbolException();
                }
            }
            intPart = intPart / 10;

            int power = 1;
            while (i < chars.Length)
            {
                if (chars[i] >= 0x30 && chars[i] <= 0x39)
                {
                    decimalPart = decimalPart + (chars[i] & 0x0F);
                    decimalPart = decimalPart * 10;
                    i++;
                    power++;
                    if (i >= chars.Length) break;
                }
                else
                {
                    throw new ImproperSymbolException();
                }
            }
            decimalPart = decimalPart / Math.Pow(10, power);

            if (sign == 1)
            {
                return (-1)*(intPart + decimalPart);
            }
            else
            {
                return (intPart + decimalPart);
            }
        }
    }
}

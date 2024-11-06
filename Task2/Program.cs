using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение без знаков препинания: ");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", "").ToLower();
            int  i,j;
            bool resoltPalindrom = false;
            for ( i = 0; i < startString.Length - 1; i++)
            {
                if (startString[i] == startString[startString.Length - 1-i])
                {
                    resoltPalindrom = true;
                }
                else
                {
                    resoltPalindrom = false;
                    break;
                }
            }
            if (resoltPalindrom == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
           
        }
    }
}

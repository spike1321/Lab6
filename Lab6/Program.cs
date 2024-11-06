using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение без знаков препинания: ");
            string startString = Console.ReadLine();
            string[] arrayString = startString.Split();
            int charCount = 0;
            string resultString = "";
            foreach (string s in arrayString)
            {
                
                if (s.Length > charCount)
                {
                    charCount = s.Length;
                    resultString = s;
                }
            }
            Console.WriteLine("Самое длинное слово в строке: " + resultString);
            Console.ReadKey();
        }
    }
}

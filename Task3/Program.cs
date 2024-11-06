using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
      
        static void Main(string[] args)
        {

             string str = "Объектно-ориентированное программирование  {ООП{ООП}ООП}  - это ";
            //  string str = "Объектно-ориентированное программирование  {ООП}  - это ";
           // string str = "Объектно-ориентированное программирование  {ООП} -- {ООП}  - это ";
            Console.WriteLine(str);
            string result = "";
            char startChar = '{';
            char continueChar = '}';

            int i = 0;
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c == startChar)
                    i++;
                else if (c == continueChar)
                    i--;
                else if (i == 0)
                    result = sb.Append(c).ToString();
            }
            result = sb.ToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

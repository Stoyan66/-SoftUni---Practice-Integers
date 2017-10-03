using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                char value = (char)i;
                Console.Write($"{value} ");
            }
            Console.WriteLine();
            
           
          

        }
    }
}

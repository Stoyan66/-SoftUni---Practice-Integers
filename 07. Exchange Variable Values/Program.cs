using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 5;
            dynamic b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            int aa = 10;
            int bb = 5;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {aa}");
            Console.WriteLine($"b = {bb}");



        }
    }
}

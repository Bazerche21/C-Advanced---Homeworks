using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintinginConsole
{
    public class PrintInConsole
    {
        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        } 

        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T item in collection)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

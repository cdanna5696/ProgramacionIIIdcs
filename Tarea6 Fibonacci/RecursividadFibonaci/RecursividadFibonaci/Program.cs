using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadFibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci r = new Fibonacci();
            int n = 0;
            while (n < 10)
            {
                Console.WriteLine(r.fibonacci(n));
                n++;
            }
            Console.ReadKey();
        }
    }
}

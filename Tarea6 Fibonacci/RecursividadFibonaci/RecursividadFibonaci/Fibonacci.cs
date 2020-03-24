﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadFibonaci
{
    class Fibonacci
    {
        public int fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}

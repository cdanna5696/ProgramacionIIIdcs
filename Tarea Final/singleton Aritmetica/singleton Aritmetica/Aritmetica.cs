using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_Aritmetica
{
    class Aritmetica
    {
        static Aritmetica instancia;
        private Aritmetica ()
        {

        }
        public static Aritmetica getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Aritmetica();
            }
            return instancia;
        }
       
        public double sumar (double a, double b)
        {
            return a + b; 
        }
        public double restar (double a, double b)
        {
            return a - b;
        }
        public double multiplicar (double a, double b)
        {
            return a * b;
        }
        public double dividir (double a, double b)
        {
            return a / b;
        }
        public double raiz (double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }
        public double potencia (double a, double b)
        {
            return Math.Pow(a, b);
        }
        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    public class Usuario
    {
        public delegate void Usuario3(int n);
        public event Usuario3 CuandoRecibaMultiplosCuatro;
        public int Sumar(int x, int y, int z)
        {
            int iSuma = x + y + z;
            if ((iSuma % 4 == 0) && (CuandoRecibaMultiplosCuatro != null))  
            { CuandoRecibaMultiplosCuatro(iSuma); }
            return iSuma;
        }
        public int Dividir(int x, int y, int z)
        {
            int ipro = (x + y + z) / 3;
            if ((ipro % 4 == 0) && (CuandoRecibaMultiplosCuatro != null))
            { CuandoRecibaMultiplosCuatro(ipro); }
            return ipro;
        }
    }
    class ProgramaEvento
    {
        static void Main()
        {
            Usuario o = new Usuario();
            o.CuandoRecibaMultiplosCuatro += RecibeMultiploCuatro;
            o.CuandoRecibaMultiplosCuatro += RecibeMultiploCuatro2;

            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int res = o.Sumar(a, b, c);
            Console.WriteLine("La suma es = {0}", res);
            int pro = o.Dividir(a,b,c/3);
            Console.WriteLine("El Promedio es = {0}", pro);

            Console.ReadKey();
        }
        static void RecibeMultiploCuatro(int n) 
        {
            Console.WriteLine("Se obtuvo un multiplo de cuatro valor: {0}", n);
        }
        static void RecibeMultiploCuatro2(int n) 
        {
            Console.WriteLine("otro cuatro valor: {0}", n);
        }
    }
}

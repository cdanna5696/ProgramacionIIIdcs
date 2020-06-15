using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_Aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Aritmetica c = Aritmetica.getInstancia();
           
            
            while (opcion != 7)
            {
                Console.WriteLine("Introduzca el primer número");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo número");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz");
                Console.WriteLine("6. Potencia");
                Console.WriteLine("7. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(c.sumar(a, b));
                        break;
                    case 2:
                        Console.WriteLine(c.restar(a, b));
                        break;
                    case 3:
                        Console.WriteLine(c.multiplicar(a, b));
                        break;
                    case 4:
                        Console.WriteLine(c.dividir(a, b));
                        break;
                    case 5:
                        Console.WriteLine(c.raiz(a, (1 / b)));
                        break;
                    case 6:
                        Console.WriteLine(c.potencia(a, b));
                        break;
                   
                }
            }
        }
    }
}

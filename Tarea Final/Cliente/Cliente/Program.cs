using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
       static void Main(string[] args)
        {
            int opcion = 0;
            

            while (opcion != 7)
            {
                Console.Clear();
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz");
                Console.WriteLine("6. Potencia");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Elija una Opción");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el primer número");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el primer número");
                double b = double.Parse(Console.ReadLine());
                double o = 0; 

                switch (opcion)
                {
                    case 1:
                        o = Clienteservidor.getInstancia().Calcularoperacion("sumar", a, b);
                        Console.WriteLine("La suma es: {0}", o);
                        break;
                    case 2:
                        o = Clienteservidor.getInstancia().Calcularoperacion("restar", a, b);
                        Console.WriteLine("La resta es: {0}", o);
                        break;
                    case 3:
                        o = Clienteservidor.getInstancia().Calcularoperacion("multiplicar", a, b);
                        Console.WriteLine("La resta es: {0}", o);
                        break;
                    case 4:
                        o = Clienteservidor.getInstancia().Calcularoperacion("dividir", a, b);
                        Console.WriteLine("La resta es: {0}", o);
                        break;
                    case 5:
                        o = Clienteservidor.getInstancia().Calcularoperacion("raíz", a, b);
                        Console.WriteLine("La resta es: {0}", o);
                        break;
                    case 6:
                        o = Clienteservidor.getInstancia().Calcularoperacion("potencia", a, b);
                        Console.WriteLine("La resta es: {0}", o);
                        break;
                }
                Console.ReadKey();
            }
       }
    }
}
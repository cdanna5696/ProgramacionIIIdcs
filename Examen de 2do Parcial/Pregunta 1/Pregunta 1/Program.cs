using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Pila<ClassDocumento> p = new Pila<ClassDocumento>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar ");
                Console.WriteLine("3. Mostras");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca Fecha:");
                        int fecha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Origen:");
                        string origen = Console.ReadLine();
                        Console.WriteLine("Introduzca Asunto");
                        string asunto = Console.ReadLine();
                        
                        ClassDocumento x = new ClassDocumento(Carta, Circular, Memorandum);
                        p.Insertar(x);
                        break;
                    case 2:
                        Carta y = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;             
                    case 4:
                        p.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }     
        }
    }
}

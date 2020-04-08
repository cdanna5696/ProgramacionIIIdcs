using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_de_Libros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
           
            Pila<Libro> p = new Pila<Libro>();
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
                        Console.WriteLine("Introduzca Nombre del libro:");
                        string nombredellibro = Console.ReadLine();
                        Console.WriteLine("Introduzca Nombre del Autor:");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Introduzca Nombre de la Editorial");
                        string editorial = Console.ReadLine();
                        Console.WriteLine("Introduzca Año de Publicacion");
                        int añodepublicacion = int.Parse(Console.ReadLine());

                        Libro x = new Libro(nombredellibro, autor, editorial, añodepublicacion);
                        p.Insertar(x);
                        break;
                    case 2:
                        Libro y = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        p.Mostrar();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}

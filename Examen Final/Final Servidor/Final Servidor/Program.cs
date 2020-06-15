using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            ServicioCliente gim = new ServicioCliente("El Gimnacio Univalle");
            // DAtos inciale1
            string o;
            while (opcion != 4)
            {

                Console.WriteLine("1. Ingresar al Gimnacio Univalle");
                Console.WriteLine("2. Salir del Gimnacio");
                Console.WriteLine("3. Mostrar Gimacio");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca Nombre");
                        String Nombre = Console.ReadLine();

                        Console.WriteLine("Introduzca Sexo");
                        String sexo = Console.ReadLine();
                        sexo sexo1;
                        Enum.TryParse(sexo, out sexo1);

                        Console.WriteLine("Introduzca Edad]");
                        int edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca su Peso");
                        int peso = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca su Altura");
                        int altura = int.Parse(Console.ReadLine());

                        o = Console.WriteLine(gim.ingresaAtleta(Nombre, sexo, edad, peso, altura);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("introduzca Nombre");
                        String p = Console.ReadLine();
                        Console.WriteLine(gim.salirAtleta(p));
                        Console.ReadKey();
                        break;
                    case 3:
                        gim.getDatos();
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}

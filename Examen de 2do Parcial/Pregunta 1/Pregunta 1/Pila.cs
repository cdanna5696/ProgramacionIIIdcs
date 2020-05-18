using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    class Pila<T>
    {
            public const int Maximo = 10;
            private T[] arreglo = new T[Maximo];
            private int tope = -1;
            public void Insertar(T valor)
            {
                if (!Llena())
                {
                    tope++;
                    arreglo[tope] = valor;
                }
                else
                {
                    Console.WriteLine("La pila esta llena");
                }
            }
            public T Eliminar()
            {
                tope--;
                return arreglo[tope + 1];
            }
            public void Mostrar()
            {
                for (int i = 0; i <= tope; i++)
                {
                    Console.WriteLine(arreglo[i].ToString() + " ");
                }
            }
            private Boolean Vacia()
            {
                return tope == -1;
            }
            private Boolean Llena()
            {
                return tope == Maximo;
            }
        
    }
}

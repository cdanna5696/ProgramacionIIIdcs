using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_covid_19
{
    class Nodo
    {
        public Infectado info;
        public Nodo Siguiente;
        public Nodo Anterior;

        public Nodo(Infectado valor)
        {
            info = valor;
            Siguiente = null;
        }
    }
    class ListaDoble
    {
        public Nodo Actual;
        public void Insertar(Infectado valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (Actual == null)
            {
                Actual = nuevo;
            }
            else
            {
                Nodo aux = Actual;
                Nodo anterior = null;
                while (aux != null && valor.apellido.CompareTo(aux.info.apellido) > 0)
                {
                    anterior = aux;
                    aux = aux.Siguiente;
                }
                if (anterior == null)
                {
                    Actual = nuevo;
                    nuevo.Siguiente = aux;
                    aux.Anterior = nuevo;
                }
                else
                {
                    anterior.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                    nuevo.Anterior = anterior;
                }

            }
        }
        public void EliminarApellido(string apellido)
        {
            if (Actual != null)
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux.Siguiente != null && aux.info.apellido != apellido)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info.apellido == apellido)
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");

            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Elementos de la lista:");
            if (Actual != null)
            {
                Nodo aux = Actual;
                while (aux != null)
                {
                    Console.WriteLine("{0}     ", aux.info);
                    aux = aux.Siguiente;

                }
            }
        }
    }
}

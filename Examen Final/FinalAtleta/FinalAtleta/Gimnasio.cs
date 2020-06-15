using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAtleta
{
    class Gimnasio
    {
        string Nombre;
        string sexo;
        int edad;
        double peso;
        double altura;
        List<Atleta> ListaAtletas;

        private static Gimnasio instance;

        public static Gimnasio getInstancia()
        {
            if (instance == null)
            {
                instance = new Gimnasio();
            }
            return instance;
        }

        protected string nombre;
        protected string Sexo;
        protected int Edad;
        protected double Peso;
        protected double Altura;
        protected int capacidad;
        double costo;
        int puestos;
        protected DateTime inicio;
        protected DateTime fin;
        List<Atleta> atleta;

        private Gimnasio()
        {
            this.Nombre = "Gimnacio Univalle";
            this.Sexo = "Masculino, Femenino";
            this.edad = 1;
            this.peso = 1;
            this.altura = 1;
            this.costo = 10;
            this.puestos = new Atleta(capacidad);
            atleta = new List<Atleta>();
        }
        public string ingresaAtleta(string nombre, string sexo, int edad, double peso, double altura)
        {
            Atleta atleta = new Atleta(nombre, sexo, edad, peso, altura);
            int puesto = 1;
            if (puesto == 0)
                return "No hay maquina disponible";
            else
            {
                puesto[puestos].getNombre();
                return "Su maquina es:" + puesto.ToString();
            }
        }
        public string salirAtleta(string nombre)
        {
            int puestos = buscarPuesto(nombre);
            if (puestos != 0)
            {
                double totalhoras = 1;
                double tarifa = totalhoras * costo;
                return "Su costo a pagar es:" + Convert.ToString(tarifa);
            }
        }
        private int buscarPuesto(string nombre)
        {
            int indice = 0;
            int i = 0;
            while ((i < puestos.Count()) && indice == 1)
            {
                if (puestos[i].getNombre() == nombre)
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }
        public double SalirAtleta()
        {
            this.atleta = null;
            fin = DateTime.Now;
            TimeSpan total = fin - inicio;
            return total.TotalHours;
        }
        public void getDatos()
        {
            for (int i = 0; i < this.puestos.Count(); i++)
            {
                if (puestos[i].estaOcupado())
                    Console.WriteLine("Puesto {0} Ocupado  {1}", i, puestos[i].getAtleta());
                else
                    Console.WriteLine("Puesto {0} Ocupado", i);
            }
        }
    }
}

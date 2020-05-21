using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    abstract class Ave
    {
        public string Nombre;
        public double Peso;
        public int TamañoAlas;

        public Ave(string nombre, double peso, int tamañoalas)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.TamañoAlas = tamañoalas;
        }
        public override string ToString()
        {
            return "Nombre" + Nombre + "Peso" + Peso + "Tamaño de Alas" + TamañoAlas;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public double getPeso()
        {
            return Peso;
        }
        public void setPeso(double peso)
        {
            this.Peso = peso;
        }
        public int getTamañoAlas()
        {
            return TamañoAlas;
        }
        public void setTamañoAlas(int tamañoalas)
        {
            this.TamañoAlas = tamañoalas;
        }
    }
}

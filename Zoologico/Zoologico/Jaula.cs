using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Jaula
    {
        protected string Animal;
        protected int Alto;
        protected int Ancho;
        protected int Largo;

        public Jaula(string animal, int alto, int ancho, int largo)
        {
            this.Animal = animal;
            this.Alto = alto;
            this.Ancho = ancho;
            this.Largo = largo;
        }
        public string getAnimal()
        {
            return Animal;
        }
        public void setAnimal(string animal)
        {
            this.Animal = animal;
        }
        public int getAlto()
        {
            return Alto;
        }
        public void setAlto(int alto)
        {
            this.Alto = alto;
        }
        public int getAncho()
        {
            return Ancho;
        }
        public void setAncho(int ancho)
        {
            this.Ancho = ancho;
        }
        public int getLargo()
        {
            return Largo;
        }
        public void setLargo(int largo)
        {
            this.Largo = ñargo;
        }
    }
}

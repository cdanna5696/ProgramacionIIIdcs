using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    abstract class Mamifero
    {
        protected string Nombre;
        protected int Temperatura;
        protected int Npatas;
        protected Color color;

        public Mamifero(string nombre, int temperatura, int npatas)
        {
            this.Nombre = nombre;
            this.Temperatura = temperatura;
            this.Npatas = npatas;
            
        }
        public override string ToString()
        {
            return "Nombre" + Nombre + "Temperatura" + Temperatura + "Numero de Patas" + Npatas;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public int getTemperatura()
        {
            return Temperatura;
        }
        public void setTemperatura(int temperatura)
        {
            this.Temperatura = temperatura;
        }
        public int getNpatas()
        {
            return Npatas;
        }
        public void setNpatas(int npatas)
        {
            this.Npatas = npatas;
        }
        public Color getColor()
        {
            return color;
        }
        public void Color (Color color)
        {
            this.color = color;
        }
    }
    enum Color
    {
        rojo, blanco, cafe, negro
    }
}

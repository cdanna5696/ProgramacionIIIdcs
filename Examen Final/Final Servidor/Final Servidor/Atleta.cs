using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Servidor
{
    class Atleta
    {
        static Atleta instancia;
        private Atleta()
        {

        }
        public static Atleta getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Atleta();
            }
            return instancia;
        }


        string Nombre;
        string Sexo;
        int Edad;
        double peso;
        double altura;

        public Atleta(string Nombre, string Sexo, int Edad, double peso, double altura)
        {
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Edad = Edad;
            this.peso = peso;
            this.altura = altura;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string getSexo()
        {
            return Sexo;
        }
        public void setsexo(string nombre)
        {
            this.Sexo = Sexo;
        }
        public int getEdad()
        {
            return Edad;
        }
        public void setedad(string nombre)
        {
            this.Edad = Edad;
        }
        public double getpeso()
        {
            return peso;
        }
        public void setpeso(string nombre)
        {
            this.peso = peso;
        }
        public double getaltura()
        {
            return altura;
        }
        public void setaltura(string nombre)
        {
            this.altura = altura;
        }

    }

    enum sexo
    {
        masculino, femenino
    }
}


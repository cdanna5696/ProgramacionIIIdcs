using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_de_rentistas
{
    class Rentista
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String sexo { get; set; }
        public int edad { get; set; }
        public String sector { get; set; }
        public Rentista(String pnombre, String papellido, String psexo, int pedad, String psector)
        {
            nombre = pnombre;
            apellido = papellido;
            sexo = psexo;
            edad = pedad;
            sector = psector;
        }
        public override string ToString()
        {
            return nombre + " " + apellido + " " + sexo + " " + edad.ToString() + " " + sector + " ";
        }
    }
}
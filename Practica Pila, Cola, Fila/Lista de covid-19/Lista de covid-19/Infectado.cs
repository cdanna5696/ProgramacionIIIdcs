using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_covid_19
{
    class Infectado
    {
        public Infectado(string dnombre, string dsegundoNombre, string dapellido, string dsegundoApellido, int dedad, string dsexo, string destado)
        {
            nombre = dnombre;
            apellido = dapellido;
            edad = dedad;
            sexo = dsexo;
            estado = destado;
        }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int edad { set; get; }
        public string sexo { set; get; }
        public string estado { set; get; }

        public override string ToString()
        {
            return nombre + "  " + apellido + "  " + edad.ToString() + "  " + sexo + "  " + estado;
        }
    }
}

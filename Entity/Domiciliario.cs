using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Domiciliario
    {
        public string ID_Trabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Estado { set; get; }
        public int Base {set;get;}

        public string FechaContrato { set; get; }

        public Domiciliario() { }

        public Domiciliario(string iD_Trabajador, string Nombre, string Apellido, string estado, int @base)
        {
            ID_Trabajador = iD_Trabajador;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            Estado = estado;
            Base = @base;
        }
    }
}

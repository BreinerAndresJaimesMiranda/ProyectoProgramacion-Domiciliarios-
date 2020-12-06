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
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string Estado { set; get; }
        public int Base {set;get;}

        public Vehiculo vehiculo { set; get; }

        public Domiciliario() { }

        public Domiciliario(string iD_Trabajador, string primerNombre, string primerApellido, string estado, int @base, Vehiculo vehiculo)
        {
            ID_Trabajador = iD_Trabajador;
            PrimerNombre = primerNombre;
            PrimerApellido = primerApellido;
            Estado = estado;
            Base = @base;
            this.vehiculo = vehiculo;
        }
    }
}

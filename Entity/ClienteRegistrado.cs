using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClienteRegistrado {

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get ; set; }
        public ClienteRegistrado() { }

        public ClienteRegistrado(string cedula, string nombre, string apellido, string direccion,string telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }

        public bool CompararCedula(string CedulaComparar) 
        {
            return this.Cedula.Equals(CedulaComparar);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vehiculo
    {
        public string Color { get; set; }

        public string Marca { get; set; }
        public int Codigo_Color { get; set; }
        public int Codigo_Marca { get; set; }
        public string Placa { get; set; }

        public string Modelo { get; set; }
        public string ID_Domiciliario { get; set; }

        public Vehiculo() { }
    }
}

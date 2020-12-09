using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VehiculoHistorial:Vehiculo
    {

        public string FechaInicioUso { get; set; }

        public string FechaFinUso { get; set; }

        public VehiculoHistorial() {}
    }
}

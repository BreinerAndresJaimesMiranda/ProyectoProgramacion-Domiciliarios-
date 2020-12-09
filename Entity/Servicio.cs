using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public int IDServicio { set; get; }
        public string IdCliente { get; set; }
        public string IdDomiciliario { get; set; }
        public DateTime Fecha { get; set; }
        public int Costo { set; get; }
        public string TelefonoEmergencia { set; get; }
        public string DestinoInicial { set; get; }
        public string DestinoFinal { set; get; }
        public string Descripcion { set; get; }        
        public Servicio() { }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public string IDServivio { set; get; }
        public int Costo { set; get; }
        public string DestinoInicial { set; get; }
        public string DestinoFinal { set; get; }
        public string Descripcion { set; get; }        
        public ClienteRegistrado ClienteRegistrado { set ; get; }
        public Domiciliario Domiciliario { set; get; }
        public string TelefonoEmergencia { set; get; }
        public Servicio() { }

        public Servicio(string iDServivio, int costo, string destinoInicial, string destinoFinal, string descripcion, ClienteRegistrado cliente, Domiciliario domiciliario)
        {
            IDServivio = iDServivio;
            Costo = costo;
            DestinoInicial = destinoInicial;
            DestinoFinal = destinoFinal;
            Descripcion = descripcion;
            ClienteRegistrado = cliente;
            Domiciliario = domiciliario;
            TelefonoEmergencia = ClienteRegistrado.Telefono;
        }

        public Servicio(string iDServivio, int costo, string destinoInicial, string destinoFinal, string descripcion, Domiciliario domiciliario,string telefonoEmergencia)
        {
            IDServivio = iDServivio;
            Costo = costo;
            DestinoInicial = destinoInicial;
            DestinoFinal = destinoFinal;
            Descripcion = descripcion;
            ClienteRegistrado = null;
            Domiciliario = domiciliario;
            TelefonoEmergencia = telefonoEmergencia;
        }

        public bool CompararIDServicio(string idServicio)
        {
            return IDServivio.Equals(idServicio);
        }

    }
}

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
        public string Placa{ get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string color, string placa, string marca, string modelo)
        {
            Color = color;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }

        public Vehiculo() { }

        public bool CompararPlaca(string placa)
        {
            return Placa.Equals(placa);
        }

    }
}

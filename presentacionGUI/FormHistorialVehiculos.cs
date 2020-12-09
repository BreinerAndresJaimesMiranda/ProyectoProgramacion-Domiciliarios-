using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace presentacionGUI
{
    public partial class FormHistorialVehiculos : Form
    {
        private VehiculoService vehiculoService;

        public FormHistorialVehiculos()
        {
            InitializeComponent();
            this.vehiculoService = new VehiculoService(ConfigConnection.connectionString);
            ActualizarDataGridVehiculos();
        }

        private void ActualizarDataGridVehiculos()
        {
            VehiculoResponse vehiculoResponse= vehiculoService.ConsultarHistorial();
            if (vehiculoResponse.Error == false)
            {
                DataGridVehiculos.DataSource = vehiculoResponse.vehiculosHistorial;
            }
            else
            {
                MessageBox.Show(vehiculoResponse.Mensaje);
            }
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

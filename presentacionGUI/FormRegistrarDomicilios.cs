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
using Entity;

namespace presentacionGUI
{
    public partial class FormRegistrarDomicilios : Form
    {
        private ServicioService servicioService;

        private ClienteRegistradoService clienteRegistradoService;

        private DomiciliarioService domiciliarioService;
        public FormRegistrarDomicilios()
        {
            InitializeComponent();
            servicioService = new ServicioService(ConfigConnection.connectionString);
            clienteRegistradoService=new ClienteRegistradoService(ConfigConnection.connectionString);
            domiciliarioService = new DomiciliarioService(ConfigConnection.connectionString);
            InicializarComboBoxs();
        }

        private void InicializarComboBoxs()
        {
            string Cedulas = clienteRegistradoService.ConsultaCedulas();
            string IdTrabajadores = domiciliarioService.ConsultarIdTrabajadores();
            TextIdCliente.Items.AddRange(Cedulas.Split(';'));
            TextIdCliente.Items.Remove("");
            TextIdCliente.SelectedItem = TextIdCliente.Items[0];
            
            TextIdClienteFiltro.Items.AddRange(Cedulas.Split(';'));
            TextIdClienteFiltro.Items.Remove("");
            TextIdClienteFiltro.SelectedItem = TextIdClienteFiltro.Items[0];

            TextIdDomiciliario.Items.AddRange(IdTrabajadores.Split(';'));
            TextIdDomiciliario.Items.Remove("");
            
            if (IdTrabajadores.Count() > 0)
            {
                TextIdDomiciliario.SelectedItem = TextIdDomiciliario.Items[0];
            }

            TextIdDomiciliarioFiltro.Items.AddRange(IdTrabajadores.Split(';'));
            TextIdDomiciliarioFiltro.Items.Remove("");
            TextIdDomiciliarioFiltro.SelectedItem = TextIdDomiciliarioFiltro.Items[0];
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            ServicioResponse servicioResponse = this.servicioService.ConsultarTodos();
            if (servicioResponse.Error == false)
            {
                DataGridServicios.DataSource = servicioResponse.Servicios;
            }
            else
            {
                MessageBox.Show(servicioResponse.Mensaje);
            }
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Servicio servicio= new Servicio();

            servicio.IdCliente = TextIdCliente.Text;
            servicio.IdDomiciliario = TextIdDomiciliario.Text;
            servicio.Costo =int.Parse( NumCosto.Value.ToString());
            servicio.TelefonoEmergencia = TextTelefonoCliente.Text;
            servicio.DestinoInicial = TextDestinoInicial.Text;
            servicio.DestinoFinal = TextDestinoFinal.Text;
            servicio.Descripcion = TextDescripcion.Text;
            
            if(TextIdDomiciliarioFiltro.Text != string.Empty)
            {
                MessageBox.Show(servicioService.Guardar(servicio));
            }

        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            string IDdomiciliario=TextIdDomiciliarioFiltro.Text;
            string IDcliente=TextIdClienteFiltro.Text;
            if (IDcliente.Equals("No aplica")) { IDcliente = string.Empty; }


            DataGridServicios.DataSource = servicioService.ConsultaFiltro(IDdomiciliario,IDcliente,FechaFiltro.Value);
        }
    }
}

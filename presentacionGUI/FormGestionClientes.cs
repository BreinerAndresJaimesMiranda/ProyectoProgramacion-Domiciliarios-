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
    public partial class FormGestionClientes : Form,IDetalle
    {
        private ClienteRegistradoService clienteRegistradoService;
        public FormGestionClientes()
        {
            InitializeComponent();
            this.clienteRegistradoService = new ClienteRegistradoService(ConfigConnection.connectionString);
        }

        public void MostrarDetalles()
        {
            lblRecordatorio.Visible = true;
        }

        public void OcultarDetalles()
        {
            lblRecordatorio.Visible = false;
        }

        private void FormGestionClientes_Load(object sender, EventArgs e)
        {
           ActualizarDataGridClientes();
        }

        private void ActualizarDataGridClientes()
        {
                 List<ClienteRegistrado> clientesRegistrados = clienteRegistradoService.ConsultarTodos().ClientesRegistrados;
                DataGridClientes.DataSource = clientesRegistrados;
            
        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            ClienteRegistrado cliente = new ClienteRegistrado();
            cliente.Cedula = TextIdentificacion.Text;
            cliente.Nombre = TextNombre.Text;
            cliente.Apellido = TextApellido.Text;
            cliente.Telefono = TextTelefono.Text;
            cliente.Direccion = TextDireccion.Text;
            this.clienteRegistradoService.Guardar(cliente);
            ActualizarDataGridClientes();
            TextIdentificacion.Text = " ";
            TextNombre.Text = " ";
            TextApellido.Text = " ";
            TextTelefono.Text = " ";
            TextDireccion.Text = " ";
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            try 
            {
                TextIdentificacion.Text = DataGridClientes.SelectedRows[0].Cells[0].Value.ToString();
                TextNombre.Text = DataGridClientes.SelectedRows[0].Cells[1].Value.ToString();
                TextApellido.Text = DataGridClientes.SelectedRows[0].Cells[2].Value.ToString();
                TextTelefono.Text = DataGridClientes.SelectedRows[0].Cells[3].Value.ToString();
                TextDireccion.Text = DataGridClientes.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccionar adecuadamente los campos del cliente que desea editar");
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            this.clienteRegistradoService.Eliminar(DataGridClientes.SelectedRows[0].Cells[0].Value.ToString());
            ActualizarDataGridClientes();
        }
    }
}

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


        private void ActualizarDataGridClientes()
        {
            ClienteRegistradoResponse clienteRegistradoResponse = clienteRegistradoService.ConsultarTodos();

            if (clienteRegistradoResponse.Error == false)
            {
                DataGridClientes.DataSource = clienteRegistradoResponse.ClientesRegistrados;
            }
            else
            {
                MessageBox.Show(clienteRegistradoResponse.Mensaje);
            }

            //GuardarPdfDomiciliarios(clientesRegistrados);
        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {

            ClienteRegistrado cliente = new ClienteRegistrado();
            cliente.Cedula = TextIdentificacion.Text.Trim();
            cliente.Nombre = TextNombre.Text.Trim();
            cliente.Apellido = TextApellido.Text.Trim();
            cliente.Telefono = TextTelefono.Text.Trim();
            cliente.Direccion = TextDireccion.Text.Trim();
            this.clienteRegistradoService.Guardar(cliente);
            ActualizarDataGridClientes();

            TextIdentificacion.Text = String.Empty;
            TextNombre.Text = String.Empty;
            TextApellido.Text = String.Empty;
            TextTelefono.Text = String.Empty;
            TextDireccion.Text = String.Empty;
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



        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridClientes();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            
            if (this.clienteRegistradoService.ConsultaIndividual(TextIdentificacion.Text) == true && TextIdentificacion.Text.Trim() != String.Empty)
            {
                ClienteRegistrado cliente = new ClienteRegistrado();
                cliente.Cedula = TextIdentificacion.Text.Trim();
                cliente.Nombre = TextNombre.Text.Trim();
                cliente.Apellido = TextApellido.Text.Trim();
                cliente.Telefono = TextTelefono.Text.Trim();
                cliente.Direccion = TextDireccion.Text.Trim();
                this.clienteRegistradoService.Actualizar(cliente);
                ActualizarDataGridClientes();
            }
            else
            {
                MessageBox.Show("No se han podido atualizar los datos del cliente seleccionado favor revisar los datos ingresados");
            }
            

        }

        private void GuardarPdfDomiciliarios(List<ClienteRegistrado> clientes)
        {
            PdfClienteRegistradoService pdfClienteRegistradoService = new PdfClienteRegistradoService();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Clientes registrados";
            saveFileDialog.InitialDirectory = "c:/document";
            saveFileDialog.DefaultExt = "pdf";
            string FileName="";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog.FileName;
                if (FileName != "" && clientes.Count > 0)
                {
                    string Mensaje = pdfClienteRegistradoService.Guardar(clientes,FileName);
                    MessageBox.Show(Mensaje);
                }
            }

        }

    }
}

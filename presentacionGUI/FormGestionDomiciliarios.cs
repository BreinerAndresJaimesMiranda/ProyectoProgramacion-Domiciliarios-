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
    public partial class FormGestionDomiciliarios : Form,IDetalle
    {
        private DomiciliarioService domiciliarioService;
        private VehiculoService vehiculoService;

        public FormGestionDomiciliarios()
        {
            InitializeComponent();
            this.domiciliarioService = new DomiciliarioService(ConfigConnection.connectionString);
            this.vehiculoService = new VehiculoService(ConfigConnection.connectionString);
            EstablecerComboboxs();
        }

        public void MostrarDetalles()
        {
            lblRecordatorio.Visible = true;
        }

        public void OcultarDetalles()
        {
            lblRecordatorio.Visible = false;
        }

        private void ActualizarDataGridDomiciliarios()
        {
            DomiciliarioResponse domiciliarioResponse = domiciliarioService.ConsultarTodos();
            if (domiciliarioResponse.Error==false)
            {
                DataGridDomiciliarios.DataSource = domiciliarioResponse.domiciliarios ;
            }
            else
            {
                MessageBox.Show(domiciliarioResponse.Mensaje);
            }
        }

        private void ActualizarDataGridVehiculos()
        {
            VehiculoResponse vehiculoResponse = vehiculoService.ConsultarTodos();
            if (vehiculoResponse.Error == false)
            {
                DataGridVehiculos.DataSource = vehiculoResponse.vehiculos;
                DataGridVehiculos.Columns.Remove("CODIGO_COLOR");
                DataGridVehiculos.Columns.Remove("CODIGO_MARCA");
            }
            else
            {
                MessageBox.Show(vehiculoResponse.Mensaje);
            }
        }

        private void GuardarDomiciliario()
        {
            Domiciliario domiciliario = new Domiciliario();
            domiciliario.Nombre = TextNombre.Text.Trim();
            domiciliario.Apellido = TextApellido.Text.Trim();
            domiciliario.Base = int.Parse( NumericBase.Value.ToString());
            domiciliario.Estado = TextEstado.Text.Trim();
            domiciliario.ID_Trabajador = TextIDdomiciliario.Text;
            MessageBox.Show(this.domiciliarioService.Guardar(domiciliario));
            ActualizarDataGridDomiciliarios();

            TextNombre.Text = String.Empty;
            TextApellido.Text = String.Empty;
            NumericBase.Value = 0;
            TextEstado.Text = String.Empty;
        }

        private void GuardarVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Codigo_Marca = TextCodigoMarca.SelectedIndex+1;
            vehiculo.Codigo_Color = TextCodigoColor.SelectedIndex+1;
            vehiculo.Modelo = TextModelo.Text;
            vehiculo.Placa = TextPlaca.Text.Trim();
            vehiculo.ID_Domiciliario = TextIDdomiciliario.Text;
            MessageBox.Show(this.vehiculoService.Guardar(vehiculo));
            ActualizarDataGridVehiculos();

            TextModelo.Text = String.Empty;
            TextPlaca.Text = String.Empty;
            TextCodigoMarca.Text = String.Empty;
            TextCodigoColor.Text = String.Empty;
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridDomiciliarios();
            ActualizarDataGridVehiculos();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if(TextIDdomiciliario.Text!=string.Empty && TextPlaca.Text!= string.Empty) {
                GuardarDomiciliario();
                GuardarVehiculo();
            }

        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDomiciliarios();
            ActualizarDataGridDomiciliarios();
            ActualizarVehiculos();
        }

        private void ActualizarVehiculos()
        {
            VehiculoResponse vehiculoResponse = vehiculoService.ConsultaIndividual(TextIDdomiciliario.Text.Trim(),TextPlaca.Text.Trim());
            if (vehiculoResponse.Error == false && TextIDdomiciliario.Text.Trim() != String.Empty && TextPlaca.Text!= String.Empty)
            {}
            else
            {
                if (vehiculoResponse.Mensaje == string.Empty) 
                {
                    GuardarVehiculo();
                }

                MessageBox.Show(vehiculoResponse.Mensaje);
            }
        }


        private void ActualizarDomiciliarios()
        {
            DomiciliarioResponse domiciliarioResponse = domiciliarioService.ConsultaIndividual(TextIDdomiciliario.Text.Trim());
            if (domiciliarioResponse.Error == false && TextIDdomiciliario.Text.Trim() != String.Empty)
            {
                Domiciliario domiciliario = new Domiciliario();
                domiciliario.ID_Trabajador = TextIDdomiciliario.Text.Trim();
                domiciliario.Nombre = TextNombre.Text.Trim();
                domiciliario.Apellido = TextApellido.Text.Trim();
                domiciliario.Base = int.Parse(NumericBase.Value.ToString());
                domiciliario.Estado = TextEstado.Text.Trim();
                ActualizarDomiciliario(domiciliario);
                ActualizarDataGridDomiciliarios();
            }
            else
            {
                MessageBox.Show(domiciliarioResponse.Mensaje);
            }
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                TextIDdomiciliario.Text = DataGridDomiciliarios.SelectedRows[0].Cells[0].Value.ToString();
                TextNombre.Text = DataGridDomiciliarios.SelectedRows[0].Cells[1].Value.ToString();
                TextApellido.Text = DataGridDomiciliarios.SelectedRows[0].Cells[2].Value.ToString();
                TextEstado.SelectedItem = DataGridDomiciliarios.SelectedRows[0].Cells[3].Value.ToString();
                NumericBase.Value = decimal.Parse(DataGridDomiciliarios.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ActualizarDataGridDomiciliarios();
        }

        
        private void ActualizarDomiciliario(Domiciliario domiciliario)
        {
            DomiciliarioResponse domiciliarioResponse = this.domiciliarioService.Actualizar(domiciliario);
            if (domiciliarioResponse.Error == false)
            {
                MessageBox.Show("Domiciliario Actualizado correctamente");
            }
            else
            {
                MessageBox.Show(domiciliarioResponse.Mensaje);
            }

        }

        private void EstablecerComboboxs()
        {
            TextCodigoMarca.Items.AddRange(vehiculoService.ConsultarMarcas().Split(';'));
            TextCodigoMarca.Items.Remove("");
            TextCodigoMarca.SelectedItem = TextCodigoMarca.Items[0];
            TextCodigoColor.Items.AddRange(vehiculoService.ConsultarColores().Split(';'));
            TextCodigoColor.Items.Remove("");
            TextCodigoColor.SelectedItem = TextCodigoColor.Items[0];

            TextEstado.Items.Add("Disponible");
            TextEstado.Items.Add("Ocupado");
            TextEstado.Items.Add("Sancionado");
            TextEstado.Items.Add("Retirado");
            TextEstado.SelectedItem = TextEstado.Items[0];
            TextEstado.Items.Remove("");
        }

        private void BotonConsultarHistorialVehiculos_Click(object sender, EventArgs e)
        {
            new FormHistorialVehiculos().Show();
        }
    }
}

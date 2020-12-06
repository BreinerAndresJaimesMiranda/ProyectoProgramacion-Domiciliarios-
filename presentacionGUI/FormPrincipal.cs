using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacionGUI
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            detalleDeFomulario = new FormInicio();
        }
        public bool Menuexpandido=false;
        private Form currentChildForm;
        private IDetalle detalleDeFomulario;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VolverInicio();
        }
        public void VolverInicio()
        {
            FormInicio formInicio = new FormInicio();
            AsignarDetalles(formInicio);
            OpenChildForm(formInicio);
            lblTitulo.Text = "Inicio";
        }

        private void MouseDetected_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (Menuexpandido == false)
                {
                    ExpandirMenu();
                }
            }
            else
            {
                if(Menuexpandido == true)
                {
                    ContraerMenu();
                }
            }
        }
        
        private void ExpandirMenu()
        {
            detalleDeFomulario.OcultarDetalles();
            Menuexpandido = true;
            pnlMenu.Width = 172;
            BotonesVisibles();
            Logo.Image = listaDeLogos.Images[0];
        }
        private void ContraerMenu()
        {
            detalleDeFomulario.MostrarDetalles();
            Menuexpandido = false;
            pnlMenu.Width = 54;
            BotonesNoVisibles();
           
            Logo.Image = listaDeLogos.Images[1];
        }
        private void BotonesNoVisibles()
        {
            btnRegistrarDomicilios.Text = "";
            btnCalculoPlanillas.Text = "";
            btnInicio.Text = "";
            btnGestionarClientes.Text = "";
            btnGestionDomiciliarios.Text = "";
        }

        private void BotonesVisibles()
        {
            btnRegistrarDomicilios.Text = "  Registrar Domicilios";
            btnCalculoPlanillas.Text = "  Calculo de Planillas";
            btnInicio.Text = "  Inicio";
            btnGestionarClientes.Text = "  Gestion de Clientes";
            btnGestionDomiciliarios.Text = "  Gestion de Domiciliarios";
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(childForm);
            pnlPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void AsignarDetalles(IDetalle detalle)
        {
            detalleDeFomulario = detalle;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            VolverInicio();
        }

        private void btnGestionDomiciliarios_Click(object sender, EventArgs e)
        {
            FormGestionDomiciliarios formGestionDomiciliarios = new FormGestionDomiciliarios();
            AsignarDetalles(formGestionDomiciliarios);
            OpenChildForm(formGestionDomiciliarios);
            lblTitulo.Text = "Gestion de Domiciliarios";
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestion de Clientes";
            FormGestionClientes formGestionClientes = new FormGestionClientes();
            AsignarDetalles(formGestionClientes);
            OpenChildForm(formGestionClientes);
        }

        private void btnRegistrarDomicilios_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Registrar Domicilios";
            FormRegistrarDomicilios formRegistrarDomicilios = new FormRegistrarDomicilios();
            OpenChildForm(formRegistrarDomicilios);
        }

        private void btnCalculoPlanillas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Calculo de Planillas";
            FormCalcularPlanilla formCalcularPlanilla = new FormCalcularPlanilla();
            OpenChildForm(formCalcularPlanilla);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacionGUI
{
    public partial class FormInicio : Form,IDetalle
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        public void MostrarDetalles()
        {
            pnlMessageDomicilios.Visible = true;
            pnlMessageClientes.Visible = true;
        }

        public void OcultarDetalles()
        {
            pnlMessageDomicilios.Visible = false;
            pnlMessageClientes.Visible = false;
        }
    }
}

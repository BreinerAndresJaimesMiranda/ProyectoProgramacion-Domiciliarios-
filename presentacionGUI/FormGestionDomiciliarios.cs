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
    public partial class FormGestionDomiciliarios : Form,IDetalle
    {
        public FormGestionDomiciliarios()
        {
            InitializeComponent();
        }

        public void MostrarDetalles()
        {
            lblRecordatorio.Visible = true;
        }

        public void OcultarDetalles()
        {
            lblRecordatorio.Visible = false;
        }

        private void FormGestionDomiciliarios_Load(object sender, EventArgs e)
        {

        }
    }
}

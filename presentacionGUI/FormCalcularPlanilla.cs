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
    public partial class FormCalcularPlanilla : Form
    {
        private DomiciliarioService domiciliarioService;

        private PlanillaService planillaService;
        public FormCalcularPlanilla()
        {
            InitializeComponent();
            domiciliarioService = new DomiciliarioService(ConfigConnection.connectionString);
            planillaService = new PlanillaService(ConfigConnection.connectionString);

            ActualizarComboBoxs();
        }

        private void ActualizarComboBoxs()
        {
            TextIdDomiciliariofiltro.Items.AddRange(domiciliarioService.ConsultarIdTrabajadores().Split(';'));
            TextIdDomiciliariofiltro.Items.Remove("");
            TextIdDomiciliariofiltro.SelectedItem = TextIdDomiciliariofiltro.Items[0];

        }

        private void BotonFiltro_Click(object sender, EventArgs e)
        {
            PlanillaResponse planillaResponse = planillaService.ConsultaFiltro(TextIdDomiciliariofiltro.Text, DateTimeFechaFiltro.Value);
            if (planillaResponse.Error == true)
            {
                MessageBox.Show(planillaResponse.Mensaje);
            }
            else
            {
                DataGridPlanillas.DataSource = planillaResponse.Planillas;
            }
        }
    }
}

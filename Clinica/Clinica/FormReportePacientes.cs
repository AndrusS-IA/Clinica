using Clinica.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FormReportePacientes : Form
    {
        public FormReportePacientes()
        {
            InitializeComponent();

            var _pacientesBL = new PacientesBL();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _pacientesBL.ObtenerPacientes();

            var _estadosBL = new EstadosBL();
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _estadosBL.ObtenerEstados();

            var _tiposBL = new TiposBL();
            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _tiposBL.ObtenerTipos();

            var reporte = new ReportePacientes();
            reporte.Database.Tables["Paciente"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Estado"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Tipo"].SetDataSource(bindingSource3);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

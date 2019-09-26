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
    public partial class FormReporteMedicos : Form
    {
        public FormReporteMedicos()
        {
            InitializeComponent();

            var _medicosBL = new MedicosBL();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _medicosBL.ObtenerMedicos();

            var _especialidadesBL = new EspecialidadesBL();
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _especialidadesBL.ObtenerEspecialidades();

            var _jornadasBL = new JornadasBL();
            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _jornadasBL.ObtenerJornadas();

            var reporte = new ReporteMedicos();
            reporte.Database.Tables["Medico"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Especialidad"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Jornada"].SetDataSource(bindingSource3);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

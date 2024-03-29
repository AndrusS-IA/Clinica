﻿using Clinica.BL;
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
    public partial class FormReporteCitas : Form
    {
        public FormReporteCitas()
        {
            InitializeComponent();

            var _citasBL = new CitasBL();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _citasBL.ObtenerCitas();

            var _pacientesBL = new PacientesBL();
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _pacientesBL.ObtenerPacientes();

            var _medicosBL = new MedicosBL();
            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _medicosBL.ObtenerMedicos();

            var reporte = new ReportedeCitas();
            reporte.Database.Tables["Cita"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Paciente"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Medico"].SetDataSource(bindingSource3);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

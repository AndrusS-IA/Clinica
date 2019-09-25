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
    public partial class MenuNew : Form
    {
        public MenuNew()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void customizeDesing()
        {
            panelArchivoSubMenu.Visible = false;
            panelReportesSubMenu.Visible = false;
            panelSeguridadSubMenu.Visible = false;
            panelAyudaSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelArchivoSubMenu.Visible == true)
                panelArchivoSubMenu.Visible = false;
            if (panelReportesSubMenu.Visible == true)
                panelReportesSubMenu.Visible = false;
            if (panelSeguridadSubMenu.Visible == true)
                panelSeguridadSubMenu.Visible = false;
            if (panelAyudaSubMenu.Visible == true)
                panelAyudaSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            var salida = MessageBox.Show("¿Desea salir del Programa?", "Salir", MessageBoxButtons.YesNo);
            if (salida == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelArchivoSubMenu);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPacientes());

            //Codigo de programacion de link de ventanas
            HideSubMenu();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMedicos());

            //Codigo de programacion de link de ventanas
            HideSubMenu();
        }

        private void btnRecetario_Click(object sender, EventArgs e)
        {
            //var formRecetarios = new FormRecetarios();
            //formRecetarios.MdiParent = this;
            //formRecetarios.Show();

             openChildForm(new FormRecetarios());

            //Codigo de programacion de link de ventanas
            HideSubMenu();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCitas());

            //Codigo de programacion de link de ventanas
            HideSubMenu();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //Codigo de programacion de link de ventanas
            HideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelReportesSubMenu);
        }

        private void btnReportPacientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReportePacientes());

            //Codigo de programacion de link de ventanas
            HideSubMenu();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSeguridadSubMenu);
        }



        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAyudaSubMenu);
        }



        private void MenuNew_Load(object sender, EventArgs e)
        {
            Login();
        }

      
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Form activeForm = null;

        private void openChildForm (Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
                activeForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(ChildForm);
                panelChildForm.Tag = ChildForm;
                panelChildForm.BringToFront();
                ChildForm.Show();
        }


    }
}

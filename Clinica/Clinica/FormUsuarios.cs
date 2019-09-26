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
    public partial class FormUsuarios : Form
    {
        UsuariosBL _usuarios;

        public FormUsuarios()
        {
            InitializeComponent();

            _usuarios = new UsuariosBL();
            listaUsuariosBindingSource.DataSource = _usuarios.ObtenerUsuario();
        }
        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            _usuarios.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();

            personalTextBox.Focus();

            DesabilitarHabilitarBotones(false);
        }


        private void DesabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }
        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea eliminar Usuario del Sistema?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }
   

        private void Eliminar(int id)
        {

            var resultado = _usuarios.ElimiarUsuarios(id);

            if (resultado == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al elimiar Usuario");
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            _usuarios.CancelarCambios();
            DesabilitarHabilitarBotones(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            var resultado = _usuarios.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void nivel2CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class UsuariosBL
    {

        Contexto _contexto;

        public BindingList<Usuario> ListaUsuarios { get; set; }

        public UsuariosBL()
        {

            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();

            ListaUsuarios.Add(nuevoUsuario);
        }

        public bool ElimiarUsuarios(int id)
        {
            foreach (var usuario in ListaUsuarios)
            {
                if (usuario.Id == id)
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }


        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese Nickname del Usuario";
                resultado.Exitoso = false;
            }

            return resultado;
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Personal { get; set; }
        public string Cargo { get; set; }
        public double Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public bool accesototal { get; set; }
        public bool nivel1 { get; set; }
        public bool nivel2 { get; set; }
    }

}

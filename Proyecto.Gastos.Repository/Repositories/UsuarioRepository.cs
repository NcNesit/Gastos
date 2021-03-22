using Proyecto.Gastos.Model.Entidades;
using Proyecto.Gastos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Gastos.Repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        List<Usuario> usuarios = new List<Usuario>();

        public Usuario GetUsuarios(string usuario, string pws)
        {
            Usuario unUsuario = new Usuario()
            {
                Id = 1,
                NombreUsuario = "Pedro",
                Correo = "correo@gmail.com",
                Contraseña = "contraseña"
            };

            return unUsuario;
        }

        public void PostUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}

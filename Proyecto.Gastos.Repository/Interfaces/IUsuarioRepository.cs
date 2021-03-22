using Proyecto.Gastos.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Gastos.Repository.Interfaces
{
    interface IUsuarioRepository
    {
        void PostUsuario(Usuario usuario);

        Usuario GetUsuarios(string usuario, string pwd);

    }
}

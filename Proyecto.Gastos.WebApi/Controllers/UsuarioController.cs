using Proyecto.Gastos.Model.Entidades;
using Proyecto.Gastos.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Proyecto.Gastos.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        UsuarioRepository repository = new UsuarioRepository();

        [HttpPost]
        [Route("api/agregarUsuario")]
        public IHttpActionResult GetEstudioSucursal([FromBody] Usuario usuario)
        {

            this.repository.PostUsuario(usuario);

            return Ok(usuario.Id);

        }

        [HttpGet]
        [Route("api/obtenerUsuario")]
        public IHttpActionResult GetEstudioSucursal(string nombreUsuario , string pws)
        {

            var usuario = this.repository.GetUsuarios(nombreUsuario , pws);


            return Ok(usuario);

        }

    }
}
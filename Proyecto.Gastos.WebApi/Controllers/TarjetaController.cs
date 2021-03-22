
using Proyecto.Gastos.Model.Entidades;
using Proyecto.Gastos.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;



namespace Proyecto.Gastos.WebApi.Controllers
{
    public class TarjetaController : ApiController
    {
        TarjetaRepository repository = new TarjetaRepository();

      
        [HttpPost]
        [Route("api/agregarTarjeta")]
        public IHttpActionResult GetEstudioSucursal([FromBody] Tarjeta tarjeta)
        {

            this.repository.PostTarjeta(tarjeta);
          
            return Ok(tarjeta);

        }

        [HttpGet]
        [Route("api/tarjeta")]        
        public IHttpActionResult GetEstudioSucursal()
        {

            var tarjetas = this.repository.GetTarjetas();
            

            return Ok(tarjetas);

        }
    }
}
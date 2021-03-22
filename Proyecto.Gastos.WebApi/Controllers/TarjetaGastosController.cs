using Proyecto.Gastos.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Proyecto.Gastos.WebApi.Controllers
{
    public class TarjetaGastosController : ApiController
    {


     


        [HttpGet]
        [Route("api/tarjetaGastos")]
        public IHttpActionResult GetEstudioSucursal()
        {
            List<TarjetaGastos> gastos = new List<TarjetaGastos>();

            TarjetaGastos unaTarjeta = new TarjetaGastos
            {
                Descripcion = "Zapatillas",
                Monto = 800,                
                Cuota = 7
            };
            TarjetaGastos unaTarjeta1 = new TarjetaGastos
            {
                Descripcion = "Computadora",
                Monto = 8900,
                Cuota = 11
            };
            TarjetaGastos unaTarjeta2 = new TarjetaGastos
            {
                Descripcion = "Microfono",
                Monto = 8000,
                Cuota = 3
            };
            TarjetaGastos unaTarjeta3 = new TarjetaGastos
            {
                Descripcion = "Teclado",
                Monto = 550,
                Cuota = 1
            };


            gastos.Add(unaTarjeta);
            gastos.Add(unaTarjeta1);
            gastos.Add(unaTarjeta2);
            gastos.Add(unaTarjeta3);



            return Ok(gastos);

        }
    }
}
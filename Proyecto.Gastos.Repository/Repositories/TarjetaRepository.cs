using Proyecto.Gastos.Model.Entidades;
using Proyecto.Gastos.Repository.Data;
using Proyecto.Gastos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Gastos.Repository.Repositories
{
    public class TarjetaRepository : ITarjetaRepository
    {
        List<Tarjeta> tarjetas = new List<Tarjeta>();

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

       
            
            
        

        public List<Tarjeta> GetTarjetas()
        {

            List<Tarjeta> tarjetas = new List<Tarjeta>();

            using ( TESTEntities db = new TESTEntities())
            {
                var testing = db.Tarjetas;

                testing.ToList().ForEach(T =>  tarjetas.Add(mapTarjetaData(T)));

                
            }

            return tarjetas;
        }

       

        public void PostTarjeta(Tarjeta tarjeta)
        {
            using (TESTEntities db = new TESTEntities())
            {

                
               db.Tarjetas.Add( mapTarjeta(tarjeta));
                db.SaveChanges();

            }

        }

        // recibe tipo base de dato y devuelve entidad
        private Tarjeta mapTarjetaData (Tarjetas tarjetaData)
        {
            Tarjeta tarjeta = new Tarjeta()
            {
                Nombre = tarjetaData.nombre,
                FechaCierre = tarjetaData.fechaCierre,
                FechaVencimiento = tarjetaData.fechaVenc,
                Monto = tarjetaData.monto,
                NroTarjeta = tarjetaData.numTarjeta

            };

            return tarjeta;
        }


        //recibe la entidad y devuelve de tipo base de dato
        private Tarjetas mapTarjeta (Tarjeta tarjeta)
        {
            Tarjetas tarjetaData = new Tarjetas()
            {
                nombre = tarjeta.Nombre,
                fechaCierre = tarjeta.FechaCierre,
                fechaVenc = tarjeta.FechaVencimiento,
                numTarjeta = tarjeta.NroTarjeta,
                monto = tarjeta.Monto,
                id = 3,
            };

            return tarjetaData;
        }


    }
}

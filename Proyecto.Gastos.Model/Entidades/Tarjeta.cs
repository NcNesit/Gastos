using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Gastos.Model.Entidades
{
    public class Tarjeta
    {      
        public string Nombre { get; set; }
        public double ? Monto { get; set; }

        public int ? NroTarjeta { get; set; }
        public DateTime ? FechaVencimiento { get; set; }
        public DateTime ?FechaCierre { get; set; }
    }
}

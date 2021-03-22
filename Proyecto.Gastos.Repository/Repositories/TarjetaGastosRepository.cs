using Proyecto.Gastos.Model.Entidades;
using Proyecto.Gastos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Gastos.Repository.Repositories
{
    class TarjetaGastosRepository : ITarjetaGastosRepository
    {
        List<TarjetaGastos> ITarjetaGastosRepository.GetTarjetasGastos()
        {
            throw new NotImplementedException();
        }

        void ITarjetaGastosRepository.PostTarjetaGastos(TarjetaGastos tarjetaGastos)
        {
            throw new NotImplementedException();
        }
    }
}

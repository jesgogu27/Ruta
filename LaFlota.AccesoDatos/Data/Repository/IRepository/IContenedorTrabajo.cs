using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFlota.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IDriverRepository Driver { get; }
        IVehicleRepository Vehicle { get; }
        IScheduleRepository Schedule { get; }
        IRouteRepository Route { get; }


        void save();
    }
}

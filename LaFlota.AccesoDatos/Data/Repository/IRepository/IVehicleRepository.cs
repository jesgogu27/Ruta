using LaFlota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository.IRepository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        IEnumerable<SelectListItem> GetListVehicles();

        void UpdateVehicle(Vehicle vehicle);
    }
}

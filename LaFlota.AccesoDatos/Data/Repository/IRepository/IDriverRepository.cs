using LaFlota.Models;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository.IRepository
{
    public interface IDriverRepository : IRepository<Driver>
    {
        //Para generar un dropdown dinamico con los conductores
        IEnumerable<SelectListItem> GetListDrivers();

        void UpDateDriver(Driver driver);
    }
}

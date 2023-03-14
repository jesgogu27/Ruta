using LaFlota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository.IRepository
{
    public interface IRouteRepository : IRepository<Route>
    {
        IEnumerable<SelectListItem> GetListRoute();
        void UpdateRoute(Route route);
    }
}

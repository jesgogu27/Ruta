using LaFlota.AccesoDatos.Data.Repository.IRepository;
using LaFlota.Data;
using LaFlota.Models;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository
{
    public class RouteRepository : Repository<Route>, IRouteRepository
    {
        private readonly ApplicationDbContext _context;
        public RouteRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetListRoute()
        {
            return _context.Routes.Select(i => new SelectListItem()
            {
                Text = i.description,
                Value = i.id.ToString()

            });
        }

        public void UpdateRoute(Route route)
        {
            var routeDB = _context.Routes.FirstOrDefault(i => i.id == route.id);
            if (routeDB != null)
            {
                routeDB.description = route.description;
                routeDB.active= route.active;

                _context.SaveChanges();
            }
        }
    }
}

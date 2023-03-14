using LaFlota.AccesoDatos.Data.Repository.IRepository;
using LaFlota.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFlota.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _context;

        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            Driver = new DriverRepository(_context);
            Vehicle = new VehicleRepository(_context);
            Schedule = new ScheduleRepository(_context);
            Route = new RouteRepository(_context);
        }

        public IDriverRepository Driver { get; private set; }
       
        public IVehicleRepository Vehicle { get; private set; }

        public IScheduleRepository Schedule { get; private set; }

        public IRouteRepository Route { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}

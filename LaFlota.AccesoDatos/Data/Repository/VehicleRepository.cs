using LaFlota.AccesoDatos.Data.Repository.IRepository;
using LaFlota.Data;
using LaFlota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetListVehicles()
        {
            return _context.Vehicles.Select(i => new SelectListItem()
            { 
                Text = i.description,
                Value = i.id.ToString()
            });
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            var vehicleDb = _context.Vehicles.FirstOrDefault(s => s.id== vehicle.id);
            if (vehicleDb!=null)
            {
                vehicleDb.description = vehicle.description;
                vehicleDb.capacity = vehicle.capacity;
                vehicleDb.year = vehicle.year;
                vehicleDb.active = vehicle.active;

                _context.SaveChanges();
            }
        }
    }
}

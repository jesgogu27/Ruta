using LaFlota.AccesoDatos.Data.Repository.IRepository;
using LaFlota.Data;
using LaFlota.Models;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository
{
    internal class DriverRepository : Repository<Driver>, IDriverRepository
    {
        
        private readonly ApplicationDbContext _context;

        public DriverRepository(ApplicationDbContext context) : base(context) 
        {
            _context= context;
        }


        public IEnumerable<SelectListItem> GetListDrivers()
        {
            return _context.Drivers.Select(i => new SelectListItem()
            {
                Text = i.last_Name,
                Value = i.id.ToString()
            });
            
           
        }

        public void UpDateDriver(Driver driver)
        {
            var driverDb = _context.Drivers.FirstOrDefault(s => s.id== driver.id);
            driverDb.first_Name = driver.first_Name;
            driverDb.last_Name= driver.last_Name;
            driverDb.ssd= driver.ssd;
            driverDb.dob= driver.dob;
            driverDb.address= driver.address;
            driverDb.city= driver.city;
            driverDb.zip= driver.zip;
            driverDb.phone= driver.phone;
            driverDb.active= driver.active;

            _context.SaveChanges();
        }
    }
}

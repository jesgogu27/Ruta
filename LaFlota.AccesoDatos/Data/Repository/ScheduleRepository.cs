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
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        private readonly ApplicationDbContext _context;
        public ScheduleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetListSchedule()
        {
            return _context.Schedules.Select(i => new SelectListItem()
            {
                Text = i.from.ToString(),
                Value = i.id.ToString(),

            });
        }

        public void UpDateSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}

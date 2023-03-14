using LaFlota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LaFlota.AccesoDatos.Data.Repository.IRepository
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        IEnumerable<SelectListItem> GetListSchedule();

        void UpDateSchedule(Schedule schedule);
    }
}


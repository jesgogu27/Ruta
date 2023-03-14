using LaFlota.AccesoDatos.Data.Repository.IRepository;
using LaFlota.Data;
using Microsoft.AspNetCore.Mvc;

namespace LaFlota.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DriversController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public DriversController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _context = context;
            _contenedorTrabajo = contenedorTrabajo;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }








        #region
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Driver.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objDelete = _contenedorTrabajo.Driver.Get(id);
            if (objDelete != null)
            {
                return Json(new { success = false, message = "Error Borrando Driver" });
            }

            _contenedorTrabajo.Driver.Remove(objDelete);
            _contenedorTrabajo.save();
            return Json(new { success = true, message = "Conductor Borrado Correctamente" });
        } 

        #endregion



    }
}

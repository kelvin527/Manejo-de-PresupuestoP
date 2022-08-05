using ManejoDePresupuesto.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ManejoDePresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            //ESTO SIRVE PARA VALIDAR LA INFORMACION QUE VIENE DEL USUARIO
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }
            return View();

        }
    }
}

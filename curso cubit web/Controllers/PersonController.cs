using curso_cubit_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_cubit_web.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new PersonViewModel
            {
                Name = "Juan Carlos"
            };

            return View(person);
        }
    }
}
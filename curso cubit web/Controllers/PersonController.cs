using curso_cubit_web.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceWCF;

namespace curso_cubit_web.Controllers
{
    public class PersonController : Controller
    {
        public readonly Service1Client serviceClient;

        public PersonController()
        {
            serviceClient = new Service1Client();
        }

        public async Task<IActionResult> IndexAsync()
        {
            var user = await serviceClient.GetUsuarioAsync("luciano", "peralta");
            var person = new PersonViewModel
            {
                Name = user.Name + " - " + user.SurName
            };

            return View(person);
        }
    }
}
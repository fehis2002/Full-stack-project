using E_commerce_Voetbal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_Voetbal.Controllers
{
    public class IntroductionController : Controller
    {

        /**
         * Introductiepagina
         */
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /**
         * Registreerpagina
         */

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        /**
         * Registreerpagina
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterVM registerVM)
        {
           if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(registerVM);
        }
    }
}

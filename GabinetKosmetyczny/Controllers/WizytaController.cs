using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GabinetKosmetyczny.Controllers
{
    public class WizytaController : Controller
    {
        // GET: Wizyta
        public ActionResult Wizyta()
        {
            ViewData["tytyl"] = "Tytuł";
            ViewData["liczba"] = 1;

            ViewBag.tytul2 = "Tytyuł2";
            ViewBag.liczba2 = 2;
            return View();
        }

    }
}
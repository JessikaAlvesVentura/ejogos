using ejogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ejogos.Controllers
{
    public class EquipeController : Controller
    {
        //ActionResult representam os vários códigos HTTP

        equipe equipeModel = new equipe();

        public IActionResult Index()
        {
            //ViewBag = reserva de espaço para armazenar informações para recuperar na view

            ViewBag.equipe = equipeModel.Lerequipes();

            return View();


        }
    }
}

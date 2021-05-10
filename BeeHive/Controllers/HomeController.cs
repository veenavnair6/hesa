using BeeLib;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BeeHive.Controllers
{
    public class HomeController : Controller
    {
        public List<Bee> Bees;

        private void GenerateBees()
        {
            Bees = new List<Bee>
            {
                new WorkerBee(),
                new WorkerBee(),
                new WorkerBee(),
                new QueenBee(),
                new QueenBee(),
                new QueenBee(),
                new DroneBee(),
                new DroneBee(),
                new DroneBee()
            };
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
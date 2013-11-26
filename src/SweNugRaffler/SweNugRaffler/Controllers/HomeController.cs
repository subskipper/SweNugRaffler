using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SweNugRaffler.Models;

namespace SweNugRaffler.Controllers
{
    public class HomeController : Controller
    {
        //ToDO: Just a temp solution till db is up
        private readonly List<ContestantEntryModel> _contestantList = new List<ContestantEntryModel>(); 

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

        [HttpPost]
        public ActionResult Index(ContestantEntryModel entry)
        {
            _contestantList.Add(entry);

            return View(entry);
        }
    }
}
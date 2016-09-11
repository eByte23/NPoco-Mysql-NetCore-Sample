using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NPoco;
using NPoco_Mysql_NetCore_Sample.Model;

namespace NPoco_Mysql_NetCore_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabase _db;

        public HomeController(IDatabase db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.Fetch<DotNetDbModel>();

            return View(new HomeViewModel { DotNetFrameworks = list });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

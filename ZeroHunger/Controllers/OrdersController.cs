using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Database;

namespace ZeroHunger.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet]
        public ActionResult History()
        {
            var db = new ZeroHungerEntities();
            return View(db.Histories.ToList());
        }

    }
}
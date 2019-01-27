using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace todo6.Controllers
{
    public class TodoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your Todo page.";

            var lista = new List<string>();
            lista.Add("só");
            lista.Add("borsó");
            lista.Add("zab");

            return View(lista);
        }
    }
}
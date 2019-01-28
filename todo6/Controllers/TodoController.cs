using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todo6.Models;

namespace todo6.Controllers
{
    public class TodoController : Controller
    {
        


        public ActionResult Index()
        {
            ViewBag.Message = "Your Todo page.";

            

            return View(MyDb.Lista);
        }

        [HttpGet]  //a routing csak a get kéréseknél irányít ide
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]  //a routing csak a post kéréseknél irányít ide
        public ActionResult Create(string name, bool isDone)
        {
            if (!string.IsNullOrEmpty(name))
            {
                //Ha nem üres a beviteli mező -> elmentjük a tartalmát és visszamegyünk az indexre
               MyDb.Lista.Add(new TodoItem() {Name=name, Done = isDone });
                return RedirectToAction("index");

            }

            //todo: mivel az adat nem valid, hibaüzenetet kellene kiadni az ügyfél felé
            return View();
        }
    }
}
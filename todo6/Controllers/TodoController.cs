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



        /// <summary>
        /// az action feladata az adott elem megjelenítése módosításra
        /// </summary>
        /// <param name="id">a módosítandó tétel egyedi azonosítója</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit( int id)
        {
            //elő kell keresni a kívánt elemet

            //alább egy olyan lista, amelyben csak a feltételnek megfelelő elemek vannak
            //MyDb.Lista.Where(x => x.Id == id);    

            var item = MyDb.Lista.Single(x => x.Id == id);  //csak akkor működik, ha egy és csak egy ilyen elem van

            // a fenti elemet kell módosítani

            // másik megoldás: ez ha nincs ilyen elem, null-al tér vissza
            var item1 = MyDb.Lista.SingleOrDefault(x => x.Id == id);

            return View(item);
        }


        [HttpPut]
        public ActionResult Edit(string name, bool isDone)
        {

            return View();
        }
    }
}
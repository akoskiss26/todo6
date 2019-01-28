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
        private List<TodoItem> lista = new List<TodoItem>
            {
                new TodoItem() { Name = "só", Done = true },
                new TodoItem() { Name = "bors", Done = true },
                new TodoItem() { Name = "liszt", Done = false },
                new TodoItem() { Name = "kapor", Done = true }
            };


        public ActionResult Index()
        {
            ViewBag.Message = "Your Todo page.";

            

            return View(lista);
        }

        public ActionResult Create(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                //Ha nem üres a beviteli mező -> elmentjük a tartalmát és visszamegyünk az indexre
                lista.Add(new TodoItem() {Name=Name, Done = true });
                return RedirectToAction("index");

            }

            return View();
        }
    }
}
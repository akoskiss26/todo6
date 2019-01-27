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

            var lista = new List<TodoItem>();
            lista.Add(new TodoItem() { Name = "só", Done = true });
            lista.Add(new TodoItem() { Name = "bors", Done = true });
            lista.Add(new TodoItem() { Name = "liszt", Done = false });
            lista.Add(new TodoItem() { Name = "kapor", Done = true });

            return View(lista);
        }
    }
}
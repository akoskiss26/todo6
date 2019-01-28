using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todo6.Models
{   /// <summary>
    /// egy ideiglenes barkács adatbázis
    /// ami kiszolgálja a webserver alkalmazásunkat
    /// </summary>
    public class MyDb
    {
        public static List<TodoItem> Lista = new List<TodoItem>
            {
                new TodoItem() { Name = "só", Done = true },
                new TodoItem() { Name = "bors", Done = true },
                new TodoItem() { Name = "liszt", Done = false },
                new TodoItem() { Name = "kapor", Done = true }
            };
    }
}
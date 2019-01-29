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
                new TodoItem() { Id = 1, Name = "só", Done = true },
                new TodoItem() { Id = 2, Name = "bors", Done = true },
                new TodoItem() { Id = 3, Name = "liszt", Done = false },
                new TodoItem() { Id = 4, Name = "kapor", Done = true }
            };
    }
}
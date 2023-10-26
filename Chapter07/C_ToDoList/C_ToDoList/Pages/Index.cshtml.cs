using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using C_ToDoList.Models;
using C_ToDoList.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_ToDoList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ToDoService _toDoService;

        public IndexModel(ToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IEnumerable<ToDoItem> Items { get; set; }

        public void OnGet()
        {
            Items = _toDoService.AllItems;
        }
    }
}

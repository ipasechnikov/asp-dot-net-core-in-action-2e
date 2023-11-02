using System.Collections.Generic;
using System.Linq;

using E_PartialViews.Models;
using E_PartialViews.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_PartialViews.Pages.ToDos
{
    public class RecentToDosModel : PageModel
    {
        public IEnumerable<ToDoItemViewModel> RecentToDos { get; set; }
        public int RecentToDosToDisplay { get; } = 3;

        public void OnGet()
        {
            RecentToDos = TaskService.AllTasks.Take(RecentToDosToDisplay);
        }
    }
}

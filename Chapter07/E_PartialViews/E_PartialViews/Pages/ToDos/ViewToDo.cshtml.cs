using System.Linq;
using E_PartialViews.Models;
using E_PartialViews.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_PartialViews.Pages.ToDos
{
    public class ViewToDoModel : PageModel
    {
        public ToDoItemViewModel Item { get; set; }

        public IActionResult OnGet(int id)
        {
            Item = TaskService.AllTasks.FirstOrDefault(x => x.Id == id);
            if (Item == null)
            {
                return RedirectToPage("RecentToDos");
            }
            return Page();
        }
    }
}

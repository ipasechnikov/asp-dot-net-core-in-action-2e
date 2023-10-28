using System.Linq;

using C_ToDoList.Models;
using C_ToDoList.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_ToDoList.Pages
{
    public class ViewToDoModel : PageModel
    {
        private readonly ToDoService _toDoService;

		public ViewToDoModel(ToDoService toDoService)
		{
			_toDoService = toDoService;
		}

        public ToDoItem ToDo { get; set; }

		public IActionResult OnGet(int id)
        {
            ToDo = _toDoService.AllItems.FirstOrDefault(x => x.Id == id);
            if (ToDo == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

using B_ConvertingToMVC.Services;
using B_ConvertingToMVC.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace B_ConvertingToMVC.Controllers
{
	public class ToDoController : Controller
	{
		private readonly ToDoService _toDoService;

		public ToDoController(ToDoService toDoService)
		{
			_toDoService = toDoService;
		}

		public IActionResult Category(string id)
		{
			var items = _toDoService.GetItemsForCategory(id);
			var viewModel = new CategoryViewModel(items);
			return View(viewModel);
		}
	}
}

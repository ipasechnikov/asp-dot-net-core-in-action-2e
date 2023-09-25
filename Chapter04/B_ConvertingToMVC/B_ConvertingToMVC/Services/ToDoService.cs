using System.Collections.Generic;
using System.Linq;

using B_ConvertingToMVC.Models;

namespace B_ConvertingToMVC.Services
{
	public class ToDoService
	{
		// These would normally be loaded from a database for example
		private static readonly List<ToDoListModel> _items = new List<ToDoListModel>
		{
			new ToDoListModel{Category= "Simple", Title="Bread"},
			new ToDoListModel{Category= "Simple", Title="Milk"},
			new ToDoListModel{Category= "Simple", Title="Get Gas"},
			new ToDoListModel{Category= "Long", Title="Write Book"},
			new ToDoListModel{Category= "Long", Title="Build Application"},
		};

		public List<ToDoListModel> GetItemsForCategory(string category)
		{
			// Filter by provided category
			return _items.Where(x => x.Category == category).ToList();
		}
	}
}

using System.Collections.Generic;

using B_ConvertingToMVC.Models;

namespace B_ConvertingToMVC.ViewModels
{
	public class CategoryViewModel
	{
		public List<ToDoListModel> Items { get; private set; }

		public CategoryViewModel(List<ToDoListModel> items)
		{
			Items = items;
		}
	}
}

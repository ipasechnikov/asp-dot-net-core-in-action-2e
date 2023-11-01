﻿using E_PartialViews.Models;
using System.Collections.Generic;

namespace E_PartialViews.Services
{
    public class TaskService
    {
        //This list would be loaded from a database or file etc
        public static List<ToDoItemViewModel> AllTasks { get; } = new List<ToDoItemViewModel>
        {
            new ToDoItemViewModel(1, "Shopping List", "Buy milk", "Buy eggs", "Buy bread"),
            new ToDoItemViewModel(2, "Agenda", "Pick up kids", "Take kids to school"),
            new ToDoItemViewModel(4, "Car stuff", "Get fuel", "Check oil", "Check Tyre pressure"),
            new ToDoItemViewModel(4, "Problems"),
            new ToDoItemViewModel(5, "Writing tasks","Write blog post", "Edit book chapter"),
        };
    }
}

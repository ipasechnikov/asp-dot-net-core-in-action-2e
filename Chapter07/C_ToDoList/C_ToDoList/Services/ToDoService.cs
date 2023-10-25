﻿using System.Collections.Generic;

using C_ToDoList.Models;

namespace C_ToDoList.Services
{
    public class ToDoService
    {
        public List<ToDoItem> AllItems { get; } = new List<ToDoItem>()
        {
            new ToDoItem(1, "Buy milk", "Buy eggs", "Buy bread"),
            new ToDoItem(2, "Pick up kids", "Take kids to school"),
            new ToDoItem(3, "Get fuel", "<strong>Check oil</strong>", "Check Tyre pressure"),
            new ToDoItem(4, "Get fuel", "Check oil", "Check Tyre pressure"),
        };
    }
}

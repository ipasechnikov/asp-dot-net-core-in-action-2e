using System.Collections.Generic;

namespace E_PartialViews.Models
{
    public class ToDoItemViewModel
    {
        public ToDoItemViewModel(int id, string title, params string[] tasks)
        {
            Id = id;
            Title = title;
            Tasks = new List<string>(tasks);
        }

        public int Id { get; }
        public string Title { get; }
        public bool IsCompleted => Tasks.Count == 0;
        public List<string> Tasks { get; }
    }
}

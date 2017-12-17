using System.Collections.Generic;
using Zad1;

namespace Zad2.Models
{
    public class CompletedViewModel
    {
        public List<TodoViewModel> TodoItems { get; set; }

        public CompletedViewModel(List<TodoItem> list)
        {
            TodoItems = new List<TodoViewModel>();
            foreach (TodoItem todoItem in list)
            {
                TodoItems.Add(new TodoViewModel(todoItem.Id, todoItem.Text, todoItem.DateCreated, todoItem.DateDue, todoItem.DateCompleted));
            }
        }
    }
}

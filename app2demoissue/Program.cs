using System;
using System.Collections.Generic;

namespace app2demoissue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todoItems = new List<TodoItem>();

            // Add initial todo items here if needed
            // todoItems.Add(new TodoItem("Initial todo item"));

            // Adding "quiz#2" to the list
            todoItems.Add(new TodoItem("quiz#2"));

            Console.WriteLine("Todo Items:");
            foreach (var item in todoItems)
            {
                Console.WriteLine($"{item.Name}, Completed: {item.IsCompleted}");
            }
        }
    }

    class TodoItem
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem(string name, bool isCompleted = false)
        {
            Name = name;
            IsCompleted = isCompleted;
        }
    }
}




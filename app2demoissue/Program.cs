namespace app2demoissue
{
    internal class TodoItems
    {
        public string Item { get; set; }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store TodoItems
            List<TodoItems> todoList = new List<TodoItems>();

            // Add "quiz#2" to TodoItems
            TodoItems quizItem = new TodoItems { Item = "quiz#2" };
            todoList.Add(quizItem);

            // Print the items in TodoItems
            Console.WriteLine("TodoItems:");
            foreach (var item in todoList)
            {
                Console.WriteLine(item.Item);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace PriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> tasks = new PriorityQueue<string, int>();

            
            tasks.Enqueue("Dishes", 1);
            tasks.Enqueue("Laundry", 2);
            tasks.Enqueue("Sweeping", 4);
            tasks.Enqueue("Mopping", 5);
            tasks.Enqueue("Dusting", 3);

            
            Console.WriteLine($"There are {tasks.Count} tasks to be completed.");

            while (tasks.Count > 0) {
                var firstTask = tasks.Peek();
                tasks.TryDequeue(out firstTask, out int priority);
                Console.WriteLine($"Dequeued Item : {firstTask} Priority Was : {priority}");

                Console.WriteLine($"There are now {tasks.Count} tasks to be completed.");
            }

        }
    }
}
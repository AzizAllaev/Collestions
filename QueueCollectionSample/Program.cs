namespace QueueCollectionSample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var queue = new Queue<string>();
			queue.Enqueue("First");
			queue.Enqueue("Second");
			queue.Enqueue("Third");

			Console.WriteLine(queue.Count);

			while (queue.Count > 0)
			{
				Console.WriteLine(queue.Dequeue());
			}

			queue.Enqueue("First");
			queue.Enqueue("Second");
			queue.Enqueue("Third");
			var first = queue.Peek();

			Console.WriteLine($"Первый в очереди {first}");

			Console.ReadLine();
		}
	}
}

using ClassLibraryModel;

namespace QueueCollectionSample
{
	internal class Program
	{
		/// <summary>
		/// Для демострации работы с Queue<T> в коде показана 
		/// работа основных методов CRUD.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Create
			var queue = new Queue<string>();
			queue.Enqueue("Tom");
			queue.Enqueue("Alice");
			queue.Enqueue("Bob");

			// Read
			foreach(var item in queue)
			{
				Console.WriteLine(item);
			}

			// Update


		}
	}
}

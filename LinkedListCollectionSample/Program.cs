using ClassLibraryModel;

namespace LinkedListCollectionSample
{
	internal class Program
	{
		/// <summary>
		/// Для демострации работы с LinkedList в коде показана 
		/// работа основных методов CRUD.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var people = new LinkedList<Person>();

			// Create
			people.AddFirst(new Person { Name = "Bekzod", Age = 23 });
			people.AddFirst(new Person { Name = "Artem", Age = 21 });
			people.AddLast(new Person { Name = "Aziz", Age = 30 });
			people.AddLast(new Person { Name = "Dima", Age = 43 });

            // Read
            foreach (var ppls in people)
            {
                Console.WriteLine("Name: {0}, Age: {1}", ppls.Name, ppls.Age);
            }

			// Update
			people.AddAfter(people.First, new Person { Name = "Bekzod", Age = 66 });
			people.AddBefore(people.Last, new Person { Name = "Artem", Age = 56 });

			Console.WriteLine("After update:");

			foreach (var item in people)
			{
				Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
			}


			// Delete
			people.RemoveFirst();
			people.RemoveLast();
			people.Remove(people.First.Next.Next); // Так тоже можно

			Console.WriteLine("After update and delete:");

            foreach (var item in people)
            {
				Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
			}

			Console.ReadKey();
		}
	}
}

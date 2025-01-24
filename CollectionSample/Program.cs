using ClassLibraryModel;

namespace CollectionSample
{
	internal class Program
	{
		/// <summary>
		/// Для демострации работы с List<T> в коде показана 
		/// работа основных методов CRUD.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Create
			var person = new List<Person>();
			person.Add(new Person { Name = "Tom", Age = 23 });
			person.Add(new Person { Name = "Alice", Age = 29 });
			person.Add(new Person { Name = "Bob", Age = 34 });
			person.Add(new Person { Name = "Sam", Age = 45 });

            // Read
            foreach (Person person1 in person)
            {
				Console.WriteLine($"Имя: {person1.Name} || Возраст: {person1.Age}");
            }

			// Update
			int index = person.BinarySearch(new Person { Name = "Anton", Age = 60 });
			person.RemoveAt(index);
			person.Reverse(index, 1);
			foreach(Person person1 in person)
			{
				Console.WriteLine($"Имя: {person1.Name} || Возраст: {person1.Age}");
			}

			// Delete
			person.RemoveRange(1, 1);
			person.RemoveAll(p => p.Age > 30);
			person.Clear();
		}
	}
}

using ClassLibraryModel;

namespace DictinaryCollection
{
	internal class Program
	{
		/// <summary>
		/// Для того чтобы показать работу с Dictionary
		/// мы показали все основные CRUD методы Dictirany
		/// </summary>
		/// <param name="args"></param>


		static void Main(string[] args)
		{
			var persons = new Dictionary<int, Person>();

			// Create
			persons.Add(1, new Person { Name = "Bekzod", Age = 23 });
			persons.Add(2, new Person { Name = "Artem", Age = 21 });
			persons.Add(3, new Person { Name = "Aziz", Age = 30 });

			// Read
			foreach (var person in persons)
			{
				Console.WriteLine($"Key: {person.Key}, Name: {person.Value.Name}, Age: {person.Value.Age}");
			}

			// Update
			if (persons.ContainsKey(1))
			{
				Console.WriteLine("Key 1 is exist");
			}
			else
			{
				persons.Add(1, new Person { Name = "Bekzod", Age = 23 });
			}

			Console.WriteLine("After adding new element");


			// Delete
			if (persons.Count > 1)
			{
				persons.Remove(1);
			}

			foreach(var person in persons)
			{
				Console.WriteLine("Key: {0}, Name: {1}, Age: {2}", person.Key, person.Value.Name, person.Value.Age);
			}

			Console.ReadKey();

		}

	}
}

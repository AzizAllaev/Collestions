namespace CollectionSample
{
	internal class Program
	{
		/// <summary>
		/// Создаём класс для коллекции
		/// </summary>
		public class Person
		{
			public string Name { get; set; }
			public int Age { get; set; }
		}

		static void Main(string[] args)
		{
			// Создаём коллекцию
			var people = new List<Person>
			{
				new Person { Name = "Bekzod", Age = 23},
				new Person { Name = "Artem", Age = 21},
				new Person { Name = "Aziz", Age = 30},
				new Person { Name = "Dima", Age = 43}
			};

			// Сортируем по возрастанию и выводим
			var sortUser = people.OrderBy(p => p.Age).ToList();

			foreach (var person in sortUser)
			{
				Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
			}

			Console.ReadKey();


			var sortUserSec = people.OrderByDescending(p => p.Age).ToList();

			// Сортируем по убыванию и выводим
			foreach (var person in sortUserSec)
			{
				Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
			}

			Console.ReadKey();
		}
	}
}

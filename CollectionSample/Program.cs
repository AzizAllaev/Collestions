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


		// Create
		static void Create(List<Person> person)
		{
			Console.WriteLine("Создание коллекции!");
			// Создаётся два листа для демонстрирования какими способами можно создать коллекцию
			var person2 = new List<Person>
			{
				new Person { Name = "Tom", Age = 23 },
				new Person { Name = "Alice", Age = 29 },
				new Person { Name = "Sam", Age = 45 }
			};

			person.Add(new Person { Name = "Sanya", Age = 33 });
			person.Add(new Person { Name = "Aziz", Age = 65 });
			person.Add(new Person { Name = "Tadd", Age = 22 });
		}

		// Read
		static void ReadAll(List<Person> person)
		{
			Console.WriteLine("Чтение коллекции:");
			foreach (Person person1 in person)
			{
				Console.WriteLine($"Имя: {person1.Name} || Возраст: {person1.Age}");
			}
		}

		// Read
		static void ReadOne(List<Person> person, string PName)
		{
			Console.WriteLine("Чтение одного элемента коллекции:");
			int index = person.FindIndex(p => p.Name == PName);
			Console.WriteLine($"Имя: {person[index].Name} || Возраст: {person[index].Age}");
		}

		// Update
		static void Update(List<Person> person)
		{
			Console.WriteLine("Обновление коллекции:");
			person[0] = new Person { Name = "Anton", Age = 60 };
			person.Reverse();
			person.ForEach(p => Console.WriteLine($"Имя: {p.Name} || Возраст: {p.Age}"));
		}

		// Delete
		static void Delete(List<Person> person)
		{
			Console.WriteLine("Удаление коллекции!");
			person.RemoveAt(1);
			person.RemoveAll(p => p.Age > 30);
			person.Clear();
		}

		static void Main(string[] args)
		{
			// CRUD
			List<Person> person = new List<Person>();
			Create(person);
			ReadAll(person);
			ReadOne(person, "Aziz");
			Update(person);
			Delete(person);

			Console.ReadLine();
		}
	}
}

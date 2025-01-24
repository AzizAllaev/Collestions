using ClassLibraryModel;

namespace StackCollectionSample
{
	internal class Program
	{
		/// <summary>
		/// Для демострации работы с Stack в коде показана 
		/// работа основных методов CRUD.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var person = new Stack<Person>();

			// Create
			person.Push(new Person { Name = "Tom", Age = 23 });
			person.Push(new Person { Name = "Alice", Age = 29 });
			person.Push(new Person { Name = "Bob", Age = 34 });
			person.Push(new Person { Name = "Sam", Age = 45 });

			// Read
			if (person.Count == 0)
			{
				foreach(var item in person)
				{
					Console.WriteLine(item);
				}
			}
			else
			{
				Console.WriteLine("Stack is empty");
			}

			// Update
			person.Pop();
			person.Push(new Person { Name = "Anton", Age = 60 });
			if(person.Contains(new Person { Name = "Anton", Age = 60 }))
			{
				person.Peek();
			}
			else
			{
				Console.WriteLine("Person Anton is not found");
			}


			// Delete
			person.Pop();
			person.Clear();
		}
	}
}

namespace DictinaryCollection
{
	internal class Program
	{
		/// <summary>
		/// Для того чтобы показать как создаются и как выполняются
		/// операции над коллекциями dictinary написана
		/// программа, в которой пользователь сам
		/// заносит данные в коллекцию.
		/// </summary>
		/// <param name="args"></param>


		// Создаём класс идентифицирующий пользователя
		public class Identificator
		{
			public int Id { get; set; }
			public string UniqueCode { get; set; }
		}
		// Создаём класс пользователя
		public class User
		{
			public string Name { get; set; }
		}


		static void Main(string[] args)
		{
			while (true)
			{

				Console.Write("1 - создать аккаунт || 2 - войти в аккаунт");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						{
							var users = new Dictionary<Identificator, User>();
							AddNewUser(users);
							break;
						}
					case "2":
						{
							var users = new Dictionary<Identificator, User>();
							Login(users);
							break;
						}
					default:
						{
							Console.WriteLine("Неверный ввод!");
							break;
						}
				}
			}
		}
		static void AddNewUser(Dictionary<Identificator, User> users)
		{
			Console.Write("Введите имя пользователя: ");
			var name = Console.ReadLine();
			Console.Write("Введите уникальный код пользователя(только буквы): ");
			var uniqueCode = Console.ReadLine();
			users.Add(new Identificator { Id = users.Count + 1, UniqueCode = uniqueCode }, new User { Name = name });
			Console.WriteLine("Пользователь успешно добавлен!");
			Console.Clear();
		}
		static void Login(Dictionary<Identificator, User> users)
		{
			Console.WriteLine("Введите уникальный код пользователя: ");
			var uniqueCode = Console.ReadLine();
			var Checklogin = users.ContainsKey(new Identificator { UniqueCode = uniqueCode });
			if(Checklogin)
			{
				Console.WriteLine("Добро пожаловать");
			}
			else
			{
				Console.WriteLine("Пользователь не найден!");
			}
			Console.Clear();
		}
	}
}

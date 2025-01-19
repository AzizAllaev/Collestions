namespace DictinaryCollection
{
	internal class Program
	{
		/// <summary>
		/// Для того чтобы показать как создаются и как выполняются
		/// операции над коллекциями dictinary написана
		/// программа, в которой пользователь сам
		/// заносит данные в коллекцию.=-=цу-ц\=
		/// </summary>
		/// <param name="args"></param>
		public class User
		{
			public string Name { get; set; }
			public string Password { get; set; }
		}
		static void Main(string[] args)
		{
			var users = new Dictionary<int, User>();
			while (true)
			{
				Console.WriteLine("1 - Добавить элемент || 2 - Найти элемент");
				Console.Write("Выберите действие: ");
				string choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						AddToCollection(users);
						break;
					case "2":
						Login(users);
						break;
					default:
						Console.Write("Неверный выбор!");
						Console.ReadKey();
						Console.Clear();
						break;
				}
			}
		}
		static void AddToCollection(Dictionary<int, User> users)
		{
			Console.Clear();
			Console.Write("Введите имя элемента: ");
			var name = Console.ReadLine();
			Console.Write("Введите пароль элемента: ");
			var password = Console.ReadLine();

			var user = new User
			{
				Name = name,
				Password = password,
			};

			users.Add(users.Count + 1, user);

			Console.Write("Элемент успешно добавлен!");
			Console.ReadKey();
			Console.Clear();
		}
		static void Login(Dictionary<int, User> users)
		{
			Console.Clear();
			Console.Write("Введите имя элемент: ");
			var name = Console.ReadLine();
			Console.Write("Введите пароль элемент: ");
			var password = Console.ReadLine();

			var user = users.Any(u => u.Value.Name == name && u.Value.Password == password);

            if (user)
            {
                Console.WriteLine("Элемент успешно найден!");
            }
			else
			{
				Console.WriteLine("Элемент не найден!");
			}
			Console.ReadKey();
			Console.Clear();
		}
	}
}

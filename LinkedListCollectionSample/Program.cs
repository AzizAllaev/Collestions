namespace LinkedListCollectionSample
{
	internal class Program
	{
		/// <summary>
		/// В данном проекте показано работа с LinkedList
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var linkedList = new LinkedList<int>();

			linkedList.AddFirst(1);
			linkedList.AddLast(3);
			linkedList.AddAfter(linkedList.First, 2);

			foreach (var item in linkedList)
			{
				Console.WriteLine(item);
			}
		}
	}
}

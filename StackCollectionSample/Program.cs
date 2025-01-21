namespace StackCollectionSample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var stack = new Stack<int>();

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);

			Console.WriteLine(stack.Count);
			Console.WriteLine(stack.Peek());
			stack.Pop();
			string str = stack.Peek().ToString();

			Console.WriteLine(str);
			stack.Clear();
			Console.ReadLine();
		}
	}
}

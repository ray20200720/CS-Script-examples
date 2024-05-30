using System;
using World;

namespace Hello
{
	class Program
	{
		static public void Main(string[] args)
		{
			Console.WriteLine("Hello World");
			const int num = 1;
			Console.WriteLine("{0}", num);
			
			Console.WriteLine("{0}", Constants.PI);
			Console.WriteLine("{0}", Constants.Letter.A);
		}
	}
}

namespace World
{
	public class Constants
	{
		public const double PI = 3.1416;
		
		public class Letter
		{
			public const char A = 'A';
			public const char B = 'B';
		}
	}
}
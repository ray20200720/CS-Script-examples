using System;


namespace Hello
{
	class Program
	{
		static public void Main(string[] args)
		{
			method1();
			method1("Hello");
			method1(1);
			method2();
		}
		
		static void method1()
		{
			Console.WriteLine("This is method 1");
		}
		
		static void method1(string msg)
		{
			Console.WriteLine($"This is method 1: {msg}");
		}
		
		// error CS0111
		// static void method1(int num)
		// {
		// 		Console.WriteLine($"This is method 1: {num}");
		// }
		
		static int method1(int num)
		{
			Console.WriteLine($"This is method 1: {num}");
			return num;
		}
		
		static void method2()
		{
			Console.WriteLine("This is method 2");
		}
	}
}

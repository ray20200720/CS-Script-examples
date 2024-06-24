using System;

public class A
{
		public void Method1()
		{
				Console.WriteLine("This is Method1 from class A");
		}
}

public class B : A
{ 
}

public class Example
{
		public static void Main(string[] args)
    {
        B b = new ();
        b.Method1();
    }
}


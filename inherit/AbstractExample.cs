using System;

public abstract class A
{	
		public abstract void Method1();
}

public class B : A
{ 
		//嘗試覆寫非虛擬成員會產生編譯器錯誤 CS0506：「<member> 無法覆寫繼承的成員 <member>，因為其未標記為 virtual、abstract 或 override」。
		// 需要將class A的Method1()加上 virtual、abstract 或 override
		public override void Method1()
		{
				Console.WriteLine("This is Method1 from class B");
		}
}

public class AbstractExample
{
		public static void Main(string[] args)
    {
        B b = new ();
        b.Method1();
    }
}


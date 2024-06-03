public class Person 
{
	private string name; 
	private int age;
	
	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	
	public string getName()
	{
		return this.name;
	}
	
	public int getAge()
	{
		return this.age;
	}
}

class Program
{
	static public void Main(string[] args)
	{
		Person bill = new Person("Ray", 40);
		Console.WriteLine("{0} is {1} years old", bill.getName(), bill.getAge());
	}
}
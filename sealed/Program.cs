using System;

namespace MyNamespace
{
		public sealed class Person
    {
				private readonly int _age;
				private readonly string _name;
				
				public Person(string name, int age)
				{
					if (age < 0)
					{
						throw new ArgumentException("Age cannot be negative.");
					}
					
					if (string.IsNullOrEmpty(name))
					{
						throw new ArgumentException("Name cannot be null or empty.");
					}
					
					_age = age;
					_name = name;
				}
				
				public int Age
				{
					get { return _age; }
				}
				
				public string Name
				{
					get { return _name; }
				}
				
				public override string ToString()
				{
					return $"I'm {_name}. I'm {_age} years old.";
				}
    }
		
		public class Student : Person
		{
			public string Major { get; set; }
		}
		
		public class TestPerson()
		{
				static void Main(string[] args)
        {  
            Console.WriteLine("Hello World!");
						Person john = new Person("John", 18);
						Console.WriteLine(john.ToString());
        }
		}
}

public enum Days
{
    None = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8,
    Friday = 16,
    Saturday = 32,
    Sunday = 64,
    Weekend = Saturday | Sunday
}

enum Priority
{
		High,
		Medium,
		Low
}

class Program
{
	static public void Main(string[] args)
	{
		Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
		Console.WriteLine(meetingDays); // Output: Monday, Wednesday, Friday
		
		Priority todo = Priority.High;
		Console.WriteLine(todo);
	}
}
IList<int> scores = new List<int> { 90, 85, 100, 70, 55, 35, 79 };

var pass = from s in scores where s>= 60 select s ;
foreach(var score in pass)
{
	Console.WriteLine("{0}", score);
}
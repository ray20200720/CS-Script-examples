string[] fruits1 = { "orange" };

string fruit1 = fruits1.SingleOrDefault();

Console.WriteLine(fruit1);

/*
 This code produces the following output:

 orange
*/

string[] fruits2 = { };

string fruit2 = fruits2.SingleOrDefault();

Console.WriteLine(
    String.IsNullOrEmpty(fruit2) ? "No such string!" : fruit2);
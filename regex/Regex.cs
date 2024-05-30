using System;
using System.Text.RegularExpressions;

string input = "Hello World";
string pattern = "Hell";

bool result = Regex.IsMatch(input, pattern);
Console.WriteLine(result);


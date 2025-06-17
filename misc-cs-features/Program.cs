Console.WriteLine("================");
Console.WriteLine("Collections");
Console.WriteLine("================");

List<string> names = ["John", "Jane", "Doe"];
List<string> moreNames = ["Alice", "Bob", "Charlie"];

Console.WriteLine("Names: " + string.Join(", ", names));
Console.WriteLine("More Names: " + string.Join(", ", moreNames));

List<string> combinedNames = [.. names, .. moreNames];
Console.WriteLine("Combined Names: " + string.Join(", ", combinedNames));


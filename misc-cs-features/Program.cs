
Console.WriteLine("================");
Console.WriteLine("Collections");
Console.WriteLine("================");

Console.WriteLine("1. Joining collections using the spread operator");
Console.WriteLine("2. Multi-dimensional arrays");
var choice = Console.ReadLine();

if (choice == "1")
{
    Console.Clear();
    Console.WriteLine("Using the spread operator to join collections:");
    SpreadOperatorDemo();
}
else if (choice == "2")
{
    Console.Clear();
    Console.WriteLine("Multi-dimensional arrays are not covered in this example.");
    MultiDimensionalArrayDemo();
}
else
{
    Console.WriteLine("Invalid choice.");
}

void MultiDimensionalArrayDemo()
{
    var theaterSeats = new string[15, 10];
    Console.WriteLine("Theater Seats:");
    for (int i = 0; i < theaterSeats.GetLength(0); i++)
    {
        for (int j = 0; j < theaterSeats.GetLength(1); j++)
        {
            theaterSeats[i, j] = $"Available";
        }
    }

    // Display the theater seats
    for (int i = 0; i < theaterSeats.GetLength(0); i++)
    {
        for (int j = 0; j < theaterSeats.GetLength(1); j++)
        {
            Console.Write(theaterSeats[i, j] + "\t");
        }
        Console.WriteLine();
    }

    
    // for (int i = 0; i < theaterSeats.GetLength(0); i++)
    // {
    //     for (int j = 0; j < theaterSeats.GetLength(1); j++)
    //     {
    //         Console.Write(theaterSeats[i, j] + " ");
    //     }
    //     Console.WriteLine();
    // }
}

static void SpreadOperatorDemo()
{
    List<string> names = ["John", "Jane", "Doe"];
    List<string> moreNames = ["Alice", "Bob", "Charlie"];

    Console.WriteLine("Names: " + string.Join(", ", names));
    Console.WriteLine("More Names: " + string.Join(", ", moreNames));

    List<string> combinedNames = [.. names, .. moreNames];
    Console.WriteLine("Combined Names: " + string.Join(", ", combinedNames));
}

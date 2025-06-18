// See https://aka.ms/new-console-template for more information
Console.WriteLine("Displaying available seats in the theater booking system...");
var c = new TheaterBooking();
c.PrintAvailableSeats();
c.BookSeat(1, 1);

Console.WriteLine("\n\n");
Console.WriteLine("Displaying available seats in the theater booking system...");
c.PrintAvailableSeats();


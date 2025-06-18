// See https://aka.ms/new-console-template for more information

internal class TheaterBooking
{
    private string[,] seats;

    public TheaterBooking(int rows = 15, int seatsPerRow = 10)
    {
        seats = new string[rows, seatsPerRow];
        InitializeSeats();
    }

    private void InitializeSeats()
    {
        for (int i = 0; i < seats.GetLength(0); i++)
        {
            for (int j = 0; j < seats.GetLength(1); j++)
            {
                seats[i, j] = "Available";
            }
        }
    }

    public void PrintAvailableSeats()
    {
        Console.WriteLine("Available seats:");
        for (int i = 0; i < seats.GetLength(0); i++)
        {
            for (int j = 0; j < seats.GetLength(1); j++)
            {
                Console.Write($"{seats[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public void BookSeat(int row, int seat)
    {
        Console.WriteLine($"Booking seat at row {row}, seat {seat}.");
        // Here you would add logic to mark the seat as booked
        // For now, we just print a message
        seats[row, seat] = "Booked";
    }
}


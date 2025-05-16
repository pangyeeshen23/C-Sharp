namespace Application
{
    public class BookDto
    {
        public Guid FlightId { get; set; }
        public BookDto(Guid flightId, string passengerEmail, int numberOfSeats)
        {
            FlightId = flightId;
            PassengerEmail = passengerEmail;
            NumberOfSeats = numberOfSeats;
        }

        public string PassengerEmail { get; set; }
        public int NumberOfSeats { get; set; }
    }
}

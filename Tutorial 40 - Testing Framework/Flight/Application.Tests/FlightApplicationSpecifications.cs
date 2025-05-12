using FluentAssertions;

namespace Application.Tests
{
    public class FlightApplicationSpecifications
    {
        [Fact]
        public void Books_flights()
        {
            BookingService bookingService = new BookingService();
            bookingService.Book(new BookDto(Guid.NewGuid(), "passenger@gmail.com", 4));
            bookingService.FindBookings().Should().ContainEquivalentOf(
                new BookingRm("passenger@gmail.com", 4)    
            );
        }
    }

    public class BookingService
    {
        public void Book(BookDto bookDto)
        {

        }

        public IEnumerable<BookingRm> FindBookings()
        {
            return new[]
            {
                new BookingRm("passenger@gmail.com", 4)
            };
        }
    }

    public class BookDto
    {
        public BookDto(Guid flightId, string passengerEmail, int numberOfSeats)
        {
            
        }
    }

    // Rm - stands for "Read Model"
    public class BookingRm
    {

        public string PassengerEmail { get; set; }
        public int NumberOfSeats { get; set; }

        public BookingRm(string passengerEmail, int numberOfSeats)
        {
            PassengerEmail = passengerEmail;
            NumberOfSeats = numberOfSeats;
        }


    }
}
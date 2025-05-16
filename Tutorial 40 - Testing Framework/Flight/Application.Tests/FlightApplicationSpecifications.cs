using FluentAssertions;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Tests
{
    public class FlightApplicationSpecifications
    {
        readonly Entities _entities = new Entities(new DbContextOptionsBuilder<Entities>().UseInMemoryDatabase("Flights").Options);
        readonly BookingService _bookingService;

        public FlightApplicationSpecifications()
        {
            _bookingService = new BookingService(_entities);
        }

        [Theory]
        [InlineData("M@m.com", 2)]
        [InlineData("a@a.com", 2)]
        public void Books_flights_should_remember_booking(string passengerEmail, int numebrOfSeats)
        {
            Flight flight = new Flight(3);
            _entities.Flights.Add(flight);
            _bookingService.Book(new BookDto(flight.Id, passengerEmail, numebrOfSeats));
            _bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(
                new BookingRm(passengerEmail, numebrOfSeats)
            );
        }

        [Theory]
        [InlineData(3)]
        public void Cancels_booking_should_free_up_seats(int initialCapacity)
        {
            Flight flight = new Flight(initialCapacity);
            _entities.Flights.Add(flight);
            _bookingService.Book(new BookDto(flightId: flight.Id, passengerEmail: "m@m.com", numberOfSeats: 2)); 
            _bookingService.CancelBooking(new CancelBookingDto(
                    flightId: flight.Id, 
                    passengerEmail: "m@m.com", 
                    numberOfSeats: 2
                )
            );
            _bookingService.GetRemainingNumberOfSeatsFor(flight.Id).Should().Be(initialCapacity);
        }
    }
}
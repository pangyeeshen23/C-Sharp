using Domain;
using FluentAssertions;

namespace Test
{
    public class FlightSpecifications
    {
        [Fact]
        public void Avoids_overbooking()
        {
            var flight = new Flight(seatCapacity: 3);
            Assert.Throws<OverbookingException>
                (() => flight.Book("yeeshen2@gmail.com", 4)
           );
        }

        [Fact]
        public void Booking_reduces_the_number_of_seats_by_one()
        {
            var flight = new Flight(seatCapacity: 3);
            flight.Book("yeess@gmail.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);
        }


        [Fact]
        public void Booking_reduces_the_number_of_seats_by_three()
        {
            var flight = new Flight(seatCapacity: 6);
            flight.Book("yeess@gmail.com", 3);
            flight.RemainingNumberOfSeats.Should().Be(3);
        }

        [Fact]
        public void Booking_reduces_the_number_of_seats_by_six()
        {
            var flight = new Flight(seatCapacity: 10);
            flight.Book("yeess@gmail.com", 6);
            flight.RemainingNumberOfSeats.Should().Be(4);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(6, 3, 3)]
        [InlineData(10, 6, 4)]
        public void Booking_reduces_the_number_of_seats_by_input(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            var flight = new Flight(seatCapacity: seatCapacity);
            flight.Book("yeess@gmail.com", numberOfSeats);
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Remembers_bookings()
        {
            Flight flight = new Flight(seatCapacity: 150);
            flight.Book("a@b.com", 4);
            flight.booking.Should().ContainEquivalentOf(new Booking("a@b.com", 4));
        }
    }
}
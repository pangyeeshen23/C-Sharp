using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class BookingService
    {
        public Entities Entities { get; set; }
        public BookingService(Entities entities)
        {
            Entities = entities;
        }

        public void Book(BookDto bookDto)
        {
            var flight = Entities.Flights.Find(bookDto.FlightId);
            flight.Book(bookDto.PassengerEmail, bookDto.NumberOfSeats);
            Entities.SaveChanges();
        }

        public IEnumerable<BookingRm> FindBookings(Guid flightId)
        {
            var flight = Entities.Flights.Find(flightId)
                .Bookings
                .Select(booking => new BookingRm(booking.Email, booking.NumberOfSeats));
            return flight;
        }

        public void CancelBooking(CancelBookingDto cancelBookingDto)
        {
            Flight flight = Entities.Flights.Find(cancelBookingDto.FlightId);
            flight.CancelBooking(cancelBookingDto.PassengerEmail);
            Entities.SaveChanges();
        }

        public object GetRemainingNumberOfSeatsFor(Guid id)
        {
            return Entities.Flights.Find(id).RemainingNumberOfSeats;
        }
    }
}

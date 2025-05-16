namespace Domain
{
    public class Flight
    {
        private List<Booking> bookings = new();

        public IEnumerable<Booking> Bookings => bookings;

        public int RemainingNumberOfSeats { get; set; }

        public Guid Id { get; }

        [Obsolete("Needed by EF")]
        public Flight()
        {
            
        }

        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public void Book(string email, int numberOfSeats)
        {
            if (numberOfSeats > RemainingNumberOfSeats)
            {
                throw new OverbookingException();
            }
            RemainingNumberOfSeats -= numberOfSeats;
            Booking booking = new Booking(email, numberOfSeats);
            bookings.Add(booking);
        }

        public void CancelBooking(string email)
        {
            Booking booking = bookings.FirstOrDefault(b => b.Email == email) ?? throw new NullReferenceException();
            bookings.Remove(booking);
            RemainingNumberOfSeats += booking.NumberOfSeats;   
        }
    }
}

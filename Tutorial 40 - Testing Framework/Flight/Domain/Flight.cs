namespace Domain
{
    public class Flight
    {
        private List<Booking> bookings = new();

        public IEnumerable<Booking> booking => bookings;

        public int RemainingNumberOfSeats { get; set; }

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
            bookings.Add(new Booking(email, numberOfSeats));
        }
    }
}

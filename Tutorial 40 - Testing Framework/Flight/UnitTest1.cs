namespace Flight
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight(seatCapacity: 3);
            flight.Book("pangyeeshen@gmail.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);
        }
    }
}
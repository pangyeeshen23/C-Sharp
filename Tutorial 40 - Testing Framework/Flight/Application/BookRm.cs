﻿namespace Application
{
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

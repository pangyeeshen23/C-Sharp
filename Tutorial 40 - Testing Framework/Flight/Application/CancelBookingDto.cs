﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CancelBookingDto
    {
        public CancelBookingDto(Guid flightId, string passengerEmail, int numberOfSeats)
        {
            FlightId = flightId;
            PassengerEmail = passengerEmail;
            NumberOfSeats = numberOfSeats;
        }

        public Guid FlightId { get; set; }

        public string PassengerEmail { get; set; }

        public int NumberOfSeats { get; set; }

    }
}

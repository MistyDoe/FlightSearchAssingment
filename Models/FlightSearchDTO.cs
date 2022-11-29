﻿namespace FlightSearchAssingment.Models
{
	public class FlightSearchDTO
	{
		public string DepartureDestination { get; set; }
		public string ArrivalDestination { get; set; }
		public bool RoundTrip { get; set; }
		public int Adults { get; set; }
		public int Children { get; set; }
		public DateTime DepartureDate { get; set; }
		public DateTime ArrivalDate { get; set; }
		public DateTime RetrunDepartureDate { get; set; }
		public DateTime RetrunArrivalDate { get; set; }
	}
}

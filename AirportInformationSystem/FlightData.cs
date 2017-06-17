using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportInformationSystem
{
    public class FlightData
    {
        public int ID { get; set; }
        public string PlaneName { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string Embarkations { get; set; }
        public string Destination { get; set; }
        public decimal TicketPrice { get; set; }
    }
}

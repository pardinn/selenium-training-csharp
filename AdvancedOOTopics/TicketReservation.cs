using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    abstract class TicketReservation
    {
        private int Seat { get; set; }
        private string Row { get; set; }
        private string EventDateTime { get; set; }
        private string EventName { get; set; }
        private string EventType { get; set; }
        private string EventLocation { get; set; }
        private double TicketCost { get; set; }

        public TicketReservation(int seatNum, string rowId, string dateTime,
                                string eventName, string type, string location, double price)
        {
            Seat = seatNum;
            Row = rowId;
            EventDateTime = dateTime;
            EventName = eventName;
            EventType = type;
            EventLocation = location;
            TicketCost = price;
        }

        public override string ToString()
        {
            return EventType.ToUpper() + ":\t" + EventName +
                "\n\tWhere:\t" + EventLocation +
                "\n\tWhen:\t" + EventDateTime +
                "\n\tCost:\t" + TicketCost.ToString("C") +
                "\n\tRow - Seat:\t" + Row + " - " + Seat;
        }

        public string BoolToString(bool isTrue)
        {
            return isTrue ? "Yes" : "No";
        }
    }
}

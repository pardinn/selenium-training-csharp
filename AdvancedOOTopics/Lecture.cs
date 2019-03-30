using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    class Lecture : TicketReservation
    {
        public Lecture(int seatNum, string rowId, string dateTime, string eventName, 
            string type, string location, double price, bool projector, string speaker) 
            : base(seatNum, rowId, dateTime, eventName, type, location, price)
        {
            ProjectionNeeded = projector;
            Speaker = speaker;
        }

        public bool ProjectionNeeded { get; set; }
        public string Speaker { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                "\n\tProjection Used:\t" + (ProjectionNeeded ? "Yes" : "No") +
                "\n\tLecture Topic:\t" + Speaker;
        }
    }
}

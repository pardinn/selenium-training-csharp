using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    class Play : TicketReservation
    {
        public Play(int seatNum, string rowId, string dateTime, string eventName, 
            string type, string location, double price,
            bool refreshments, int numActors, string playInfo) 
            : base(seatNum, rowId, dateTime, eventName, type, location, price)
        {
            RefreshmentsServed = refreshments;
            NumberOfActors = numActors;
            PlaySpecificInfo = playInfo;
        }

        public bool RefreshmentsServed { get; set; }
        public int NumberOfActors { get; set; }
        public string PlaySpecificInfo { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                "\n\tPlay Info:\t" + PlaySpecificInfo +
                "\n\tNumber Of Actors:\t" + NumberOfActors +
                "\n\tRefreshments Available:\t" + BoolToString(RefreshmentsServed);
        }
    }
}

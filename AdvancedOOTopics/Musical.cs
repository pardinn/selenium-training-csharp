using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    class Musical : TicketReservation
    {
        public Musical(int seatNum, string rowId, string dateTime, string eventName,
            string type, string location, double price, string performer,
            bool memoriability, bool backStage, bool signsAutograph)
            : base(seatNum, rowId, dateTime, eventName, type, location, price)
        {
            PerformerName = performer;
            MemoriabilityOnSale = memoriability;
            BackStageOffered = backStage;
            SignsAutographAvailable = signsAutograph;
        }

        public string PerformerName { get; set; }
        public bool MemoriabilityOnSale { get; set; }
        public bool BackStageOffered { get; set; }
        public bool SignsAutographAvailable { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                "\n\tPerformer:\t" + PerformerName +
                "\n\tMemoriability:\t" + BoolToString(MemoriabilityOnSale) +
                "\n\tBackstage Offer:\t" + BoolToString(BackStageOffered) +
                "\n\tSigns Autograph:\t" + BoolToString(SignsAutographAvailable);
        }
    }
}

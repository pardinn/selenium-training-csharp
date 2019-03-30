using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdvancedOOTopics
{
    [TestClass]
    public class TicketReservationTest
    {
        [TestMethod]
        public void Play_Reservation_Test()
        {
            Play newPlay = new Play(24, "M", "04/23/2019", "Sherlock Holmes", "Play", 
                "Theater", 35.70, true, 75, "Drama");
            Console.WriteLine(newPlay);
        }

        [TestMethod]
        public void Lecture_Reservation_Test()
        {
            Lecture newLecture = new Lecture(2, "D", "05/01/2019", "Automation Testing With C#", "Lecture",
                "New Hall", 50, true, "Nikolay Advolokin");
            Console.WriteLine(newLecture);
        }

        [TestMethod]
        public void Musical_Reservation_Test()
        {
            Musical newMusical = new Musical(35, "A", "04/01/2019", "Scenes From New York", "Musical",
                "Theater", 250.00, "Dream Theater", true, true, true);
            Console.WriteLine(newMusical);
        }
    }
}

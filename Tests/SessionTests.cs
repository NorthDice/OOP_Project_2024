using MainForm.Classes.Cinema;
using MainForm.Enums;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Tests
{
    [TestClass]
    public class SessionTests
    {
        [TestMethod]
        public void Date_SetValidDate_ShouldSetDate()
        {
            // Arrange
            DateTime validDate = DateTime.Now.Date.AddDays(1); 
            TimeSpan timeOfDay = DateTime.Now.TimeOfDay; 
            var session = new Session(validDate, "Test Film", Halls.FifthHall, timeOfDay);

            // Act
            var resultDate = session.Date;

            // Assert
            Assert.AreEqual(validDate, resultDate);

        }

        [TestMethod]
        public void Date_SetPastDate_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DateTime pastDate = DateTime.Today.AddDays(-1); 

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Session(pastDate, "Test Film", Halls.FifthHall, TimeSpan.FromHours(18)));
        }

        [TestMethod]
        public void Time_SetValidTime_ShouldSetTime()
        {
            //Arrange
            TimeSpan validTime = TimeSpan.FromHours(18);
            var session = new Session(DateTime.Today, "Test Film", Halls.FifthHall, validTime);

            //Act
            var resultTime = session.Time;

            //Assert

            Assert.AreEqual(validTime, resultTime);
        }

        [TestMethod]
        public void Time_SetPastTime_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            TimeSpan pastTime = TimeSpan.FromHours(-1);
            Session session = new Session(DateTime.Today, "Test Film", Halls.FifthHall, TimeSpan.FromHours(18));

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.Time = pastTime);
        }


        [TestMethod]
        public void HallNumber_SetValidHallNumber_ShouldSetHallNumber()
        {
            //Arrange
            Halls validHall = Halls.FifthHall;
            var session = new Session(DateTime.Today, "Test Film", validHall, TimeSpan.FromHours(18));
            //Act
            var resultHallNumber = session.HallNumber;
            //Assert
            Assert.AreEqual(resultHallNumber, validHall);
        }

        [TestMethod]

        public void HallNumber_SetInvalidHallNumber_ShouldThrowArgumentException()
        {
            //Arrange
            Halls invalidHall = (Halls)1000;

            //Act&Assert

            Assert.ThrowsException<ArgumentException>(() => new Session(DateTime.Today, "Test Film", invalidHall, TimeSpan.FromHours(18)));
        }

        [TestMethod]
        public void FilmName_SetValidFilmName_ShouldSetFilmName()
        {
            //Arrange
            string ValidFilmName = "Avatar";
            var session = new Session(DateTime.Today, ValidFilmName, Halls.FifthHall, TimeSpan.FromHours(18));
            //Act
            string resulFilmName = session.FilmName;
            //Assert

            Assert.AreEqual(resulFilmName, ValidFilmName);
        }
        [TestMethod]
        public void FilmName_SetEmptyFilmName_ShouldThrowArgumentException()
        {
            //Arrange 
            string invalidFilmName = "";

            //Act&Assert
            Assert.ThrowsException<ArgumentException>(() => new Session(DateTime.Today, invalidFilmName, Halls.FifthHall, TimeSpan.FromHours(18)));
        }
        [TestMethod]
        public void ViewSessionInformation_ShouldPrintCorrectInformation()
        {
            // Arrange
            DateTime futureDate = DateTime.Now.AddDays(1); 
            TimeSpan futureTime = DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(1)); 
            Halls hallNumber = Halls.FirstHall;
            string filmName = "Test Film";
            Session session = new Session(futureDate, filmName, hallNumber, futureTime); 
            ListBox listBox = new ListBox();

            session.ViewSessionInformation(listBox);

        }
    }
}
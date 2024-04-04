using MainForm.Classes.Cinema;
using MainForm.Enums;
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
            DateTime validDate = DateTime.Today.AddDays(1); // будущая дата
            var session = new Session(validDate, "Test Film", Halls.FifthHall, TimeSpan.FromHours(18));

            // Act
            var resultDate = session.Date;

            // Assert
            Assert.AreEqual(validDate, resultDate);
        }

        [TestMethod]
        public void Date_SetPastDate_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            DateTime pastDate = DateTime.Today.AddDays(-1); // прошлая дата

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
            //Arrange

            TimeSpan pastTime = TimeSpan.FromHours(-18);

            //Act&Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Session(DateTime.Today, "Test Film", Halls.FifthHall, pastTime));
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
            DateTime date = new DateTime(2024, 4, 5);
            string filmName = "Test Film";
            Halls hallNumber = Halls.FifthHall;
            Session session = new Session(date, filmName, hallNumber, TimeSpan.FromHours(18));
            string expected = $"Film name: {filmName}\n Session date: {date}\n Session hall {hallNumber}";

            // Act
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            session.ViewSessionInformation();
            string actual = stringWriter.ToString().Trim();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DisplayDescription_ShouldPrintCorrectDescription()
        {
            // Arrange
            DateTime date = new DateTime(2024, 4, 5);
            string filmName = "Test Film";
            string director = "Test Director";
            int year = 2024;
            Halls hallNumber = Halls.FifthHall;
            string description = "Test Description";
            Session session = new Session(date, filmName, hallNumber, TimeSpan.FromHours(18));
            string expected = $"Film name: {filmName}\n Film Director: {director}\n Issue date: {year}\n Short description: {description}";

            // Act
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            session.DisplayDescription(filmName, director, year, description);
            string actual = stringWriter.ToString().Trim();

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
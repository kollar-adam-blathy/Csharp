using Basic.Fundamentals;

namespace Basic.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            // Arrange
            Reservation reservation = new Reservation();
            // Act
            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            //Arrange
            User user = new User();
            Reservation reservation = new Reservation { MadeBy = user};
            //Act
            bool result = reservation.CanBeCancelledBy(user);
            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnFalse()
        {
            //Arrange
            Reservation reservation = new Reservation { MadeBy = new User() };
            //Act
            bool result = reservation.CanBeCancelledBy(new User());
            //Assert
            Assert.That(result, Is.False);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize] // 각 테스트 메소드 실행할때, 디폴트값 선언
        public void Initalize()
        {
            Console.WriteLine("Initalize");
        }
        [TestMethod]
        [Priority(0)]
        public void TC0001_01_CanBeCanceledBy_UserIsAdmin_returnsTrue()
        {
            // given (준비) == arrange : 테스트할 메소드를 인스턴스
            var reservation = new ReservationTest();

            // when (실행) == act : 테스트할 시나리오를 구현
            var result = reservation.canBeCanceledBy(new User(true));
            Console.WriteLine("유저가 주인인 경우 테스트");

            // then (검증) == assert : 예상 값과 일치하는지 확인
            Assert.IsTrue(result);

            Console.WriteLine(0);
        }
        [TestMethod]
        [Priority(1)] // -> priorty 안먹힘
        public void TC0001_02_canBeCanceledBy_SameUser_returnsTrue()
        {
            // Arrange
            var reservation = new ReservationTest();
            reservation.reservedUser = new User(false);

            // Act
            var result = reservation.canBeCanceledBy(reservation.reservedUser);

            // Assert
            Assert.IsTrue(result);
            Console.WriteLine(1);
        }
        [TestMethod]
        [Priority(2)]
        public void TC0001_03_canBeCanceledBy_AnotherUser_returnsFalse()
        {
            // Arrange
            var reservation = new ReservationTest();
            reservation.reservedUser = new User(false);
            // Act
            var result = reservation.canBeCanceledBy(new User(false));

            // Assert
            Assert.IsFalse(result);

            Console.WriteLine(2);
        }
        [TestMethod]
        public void TC0001_04_testTest()
        {
            var boolean = false;

            //Assert.IsTrue(boolean);
            try
            {
                Assert.IsTrue(true); 
            }
            catch(Exception)
            {
                Assert.Fail("fail!!!"); // Assert.IsTrue(false) 일때 넘어온다.
            }
        }
    }
}
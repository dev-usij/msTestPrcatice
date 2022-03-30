using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize] // �� �׽�Ʈ �޼ҵ� �����Ҷ�, ����Ʈ�� ����
        public void Initalize()
        {
            Console.WriteLine("Initalize");
        }
        [TestMethod]
        [Priority(0)]
        public void TC0001_01_CanBeCanceledBy_UserIsAdmin_returnsTrue()
        {
            // given (�غ�) == arrange : �׽�Ʈ�� �޼ҵ带 �ν��Ͻ�
            var reservation = new ReservationTest();

            // when (����) == act : �׽�Ʈ�� �ó������� ����
            var result = reservation.canBeCanceledBy(new User(true));
            Console.WriteLine("������ ������ ��� �׽�Ʈ");

            // then (����) == assert : ���� ���� ��ġ�ϴ��� Ȯ��
            Assert.IsTrue(result);

            Console.WriteLine(0);
        }
        [TestMethod]
        [Priority(1)] // -> priorty �ȸ���
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
                Assert.Fail("fail!!!"); // Assert.IsTrue(false) �϶� �Ѿ�´�.
            }
        }
    }
}
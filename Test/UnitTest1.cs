using CICD;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestCarID()
        {
            // Arrange
            var expected = true;
            var car = new Car(); // ��� �����

            car.id = 1;
            // Act
            var result = car.CheckID(); //������������ �����

            // Assert
            //Assert.Equal(expected, result); // ��� xUnit

            // Assert.AreEqual(expected, result); // ��� NUnit
        }
    }
}
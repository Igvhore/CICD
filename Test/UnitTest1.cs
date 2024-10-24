using CICD;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestCarID()
        {
            // Arrange
            //var expected = true;
            var car = new Car(); // Ваш класс
             
            car.id = 1;
            // Act
            var result = car.CheckID(); //тестиируемый метод

            // Assert
            //Assert.Equal(expected, result); // Для xUnit

            // Assert.AreEqual(expected, result); // Для NUnit
        }

        [Fact]
        public void TestSetCarName()
        {
            // Arrange
            //var expected = true;
            var car = new Car(); // Ваш класс

            car.SetCarName("BMW");
            // Act
            //var result = car.CheckID(); //тестиируемый метод

            // Assert
            //Assert.Equal(expected, result); // Для xUnit

            // Assert.AreEqual(expected, result); // Для NUnit
        }

        [Fact]
        public void TestSetDescriptionName()
        {
            // Arrange
            //var expected = true;
            var car = new Car(); // Ваш класс

            car.SetCarDescription("Lol");
            // Act
            //var result = car.CheckID(); //тестиируемый метод

            // Assert
            //Assert.Equal(expected, result); // Для xUnit

            // Assert.AreEqual(expected, result); // Для NUnit
        }
    }
}
namespace Challenge21.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(6);

            // act
            var result = employee.Result;

            //assert
            //Assert.AreEqual(17, result);
            Assert.That(result, Is.EqualTo(17));
          

        }

        [Test]
        public void WhenEmployeeCollectFourScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(6);
            employee.AddScore(-2);

            // act
            var result = employee.Result;

            //assert
            //Assert.AreEqual(15, result);
            Assert.That(result, Is.EqualTo(15));


        }
    }
}
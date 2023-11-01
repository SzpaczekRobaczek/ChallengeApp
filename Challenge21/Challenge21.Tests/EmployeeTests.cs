namespace Challenge21.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldCorrectMinGrade()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(80);
            employee.AddGrade(60);
            employee.AddGrade(70);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(60, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldCorrecMaxtGrade()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(7, statistics.Max);
        }
        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldCorrecAverageGrade()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Average);
        }

        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldCorrecAverageLetter()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(55);
            employee.AddGrade(60);
            employee.AddGrade(70);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}
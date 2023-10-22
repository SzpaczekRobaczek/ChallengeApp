namespace Challenge21.Tests
{
    public class TypeTests
    {
        
        [Test]
        public void ReferenceTypeGetEmployeeShouldReturnDifferentObjects()
        {
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");
            Assert.AreNotEqual(employee1, employee2);
  
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

        [Test]
        public void ValueTypeTestOfSurname()
        {
            var employee1 = GetEmployee("Adam", "Kowalski");
            var employee2 = GetEmployee("Adam", "Lewandowski");
            Assert.AreNotEqual(employee1.Surname, employee2.Surname);

        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }

        [Test]
        public void ValueTypeTheTwoNumbersShouldBeTheSame()
        {
            int number1 = 2;
            int number2 = 2;
            Assert.AreEqual(number1, number2);
        }
    }
}

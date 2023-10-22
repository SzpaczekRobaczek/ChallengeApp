namespace Challenge21
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name)
        {
            this.Name = name;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Result
        {
            get
            {
                return score.Sum();
            }

        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}

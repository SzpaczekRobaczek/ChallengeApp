namespace Challenge21
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDeleagate(object sender, EventArgs args);

        public abstract event GradeAddedDeleagate GradeAdded;

        public EmployeeBase(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}

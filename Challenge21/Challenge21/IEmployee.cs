using static Challenge21.EmployeeBase;

namespace Challenge21
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        char Sex { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(long grade);

        void AddGrade(double grade);

        void AddGrade(char grade);

        event GradeAddedDeleagate GradeAdded;

        Statistics GetStatistics();
    }
}

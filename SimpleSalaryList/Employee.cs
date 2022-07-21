using System.Globalization;

namespace SimpleSalaryList
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            if (percentage > 0) Salary += Salary * percentage / 100.0;
        }

        public void DecreaseSalary(double percentage)
        {
            if (percentage > 0) Salary -= Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

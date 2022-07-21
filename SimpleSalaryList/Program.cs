using System;
using System.Globalization;

namespace SimpleSalaryList
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registred? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1}:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                
                if (employees.Find(x => x.Id == id) != null)
                {
                    Console.WriteLine("This ID is already being used.");

                    i--;
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new Employee(id, name, salary));
                }
            }

            Console.Write("\nEnter the employee ID that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage: ");
            double salaryPercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee emp = employees.Find(x => x.Id == employeeId);

            if (emp != null)
            {
                emp.IncreaseSalary(salaryPercentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}

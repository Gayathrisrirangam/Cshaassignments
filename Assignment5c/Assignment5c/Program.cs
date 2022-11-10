using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    internal class Employee
    {
        public int Eid { get; set; }
        public string EName { get; set; }
        public string Erole { get; set; }
        public int Salary { get; set; }
        public string Location { get; set; }

    }
    public class EmployeeDetails
    {
        public static void Main()
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee
            {
                Eid = 11,
                EName = "Gayathri",
                Erole = "Trainee",
                Location = "Banglore",
                Salary = 20000
            });
            Employees.Add(new Employee
            {
                Eid = 12,
                EName = "srirangam",
                Erole = "Trainee",
                Location = "Banglore",
                Salary = 20000
            });
            Employees.Add(new Employee
            {
                Eid = 13,
                EName = "sasta",
                Erole = "Trainee",
                Location = "chennai",
                Salary = 20000
            });


            foreach (Employee e in Employees)
            {
                Console.WriteLine(e.Eid + " " + e.EName + " " + e.Erole + " " + e.Location + " " + e.Salary);
            }
            Console.ReadLine();

            Console.WriteLine("Total no.of Employees:");
            Console.WriteLine(Employees.Count());
            Console.ReadLine();

            Employee E = Employees.Find(emp => emp.EName.StartsWith("P"));
            Console.WriteLine("Eid = {0}", E.Eid);
            Console.ReadLine();





        }
    }
}
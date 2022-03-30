using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Employee employee1= new Employee("Ali",25, 500);
            Employee employee2 = new Employee("Zaur", 30, 1000);
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Department department1 = new Department();
            department1.AddEmployee(employee1);
            foreach (Employee item in department1._employeesArray)
            {
                Console.WriteLine(employee1.ToString());
            }
            Department department = new Department("Socar", 50);
            Console.WriteLine("\n Enter Depertment name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("n Enter employee limit");
            string EmployeeLimit = Console.ReadLine();

            int employeeLimit = 50;
            string[] EmployeesArrar = { "Zehra", "Nicat", "Ali", "Ahmed", "Leyla" };
           
         
            foreach (var item in EmployeesArrar)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}

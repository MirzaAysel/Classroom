using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Interface;
using ConsoleApp.Models;

namespace ConsoleApp.Models
{
    class Employee : IPerson
    {
        private static int _idCounter;
        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo()
        {
            Console.WriteLine("Please indicate your education, language skills and ability to work in a team.");
            return Console.ReadLine();
        }
        public int Id { get; }
        public int Salary

        {
            get
            {
                return Salary;
            }
            set
            {
                if (value > 5 && value < 35)
                {
                    Salary = value;
                }
            }
        }


        static Employee()
        {
            _idCounter = 0;
        }
        public Employee()
        {
            Id = _idCounter++;
        }
        public Employee(string name, int age, int salary):this()
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public override string ToString()
        {
            return ToString();
        }

    }
}

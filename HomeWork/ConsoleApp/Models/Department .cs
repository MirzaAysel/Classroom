using System;
using ConsoleApp.Exseption;
using ConsoleApp;


namespace ConsoleApp.Models
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit
        {
            get
            {
                return EmployeeLimit;
            }
            set
            {
                if (value > 0 && value < 50)
                {
                    EmployeeLimit = value;
                }
            }
        }
       

        public Employee[] _employeesArray = new Employee[0];


        private string _name { get; set; }
        private int _employeeLimit { get; set; }

        private Employee this[int index]
        {
            get
            {
                return _employeesArray[index];
            }
            set
            {
                _employeesArray[index] = value;
            }
        }

        public Department()
        {

        }
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;


        }
       

        Employee employee = new Employee();

        public  void AddEmployee(Employee employee)
        {
 
           
            
            Console.WriteLine(" Welcome. Please enter the information");
            Array.Resize(ref _employeesArray, _employeesArray.Length + 1);
            _employeesArray[_employeesArray.Length - 1] = employee;

            if (_employeesArray.Length < EmployeeLimit)
            {
             _employeesArray.AddEmployee(employee);

            }
            else
            {

                throw new CapacityLimitException();
            }

          




        }


    }
}
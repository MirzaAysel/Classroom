using System;
using Praktika3.Models;
using Praktika3.Interface; 

namespace Praktika3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            User user = new User("Aysel Mirze", "mirzeaysel@gmail.com");
            Student student = new Student("Aysel Mirze", 0);

        ShowInfo:

        menu:
            Console.WriteLine("====== User Menu ======\n" + "1. Show info\n" + "2. Create new group\n");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            Group group = new Group("AA101", 10);

            switch (choice)
            {
                case "1":
                    user.ShowInfo();
                    goto menu;
                case "2":
                    string groupNo = "AA101";
                    int studentLimit = 10;
 

                    if (Group.CheckGroupNo("AA101") == true)
                    {
                        Console.WriteLine(groupNo);
                    }
                    if (studentLimit < 5 || studentLimit > 18) ;
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine("Qrup uğurla yaradıldı");

                    Group group1 = new Group(groupNo, studentLimit);

                    bool check = true;
                            Console.WriteLine("1.Show all students");
                            Console.WriteLine("2.Get student by id");
                            Console.WriteLine("3.Add student");
                    string groupChoice = Console.ReadLine();
                    switch (groupChoice)
                    {
                        case "1":
                            group.GetAllStudents();

                            break;
                        case "2":
                            Console.WriteLine(student.Id);
                            break;
                        case "3":
                            student.StudentInfo();
                            // Group group1 = new Group(groupNo, studentLimit);
                            group1.AddStudent();
                            break;
                        case "0":
                            Console.WriteLine("Menu Stop");
                            break;
                        default:
                            Console.WriteLine("make the right groupChoice");
                            break;
                    }
                    break;
                default:
                    break;    
            }

        }

    }
}
using System;
using TaskWeapon.Models;

namespace TaskWeapon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weapon weapon = new Weapon();

            weapon.MagazineSize = 30;
            weapon.CurrentbulletCount = 30;
            weapon.FireMode = "single";
     
            int choice;

            do
            {
                Console.WriteLine("Choose the command");
                Console.WriteLine("0:Information\n" +
                    "1:Shoot\n" +
                    "2:Fire\n" +
                    "3:GetRemainBulletCount\n" +
                    "4:Reload\n" +
                    "5:ChangeMode\n" +
                    "6.Stop Program\n" +
                    "7:Edit\n");

               
                int capacity = weapon.MagazineSize;
                int count = weapon.CurrentbulletCount;
                string mode = weapon.FireMode;
                

               choice = Convert.ToInt32(Console.Read());
                switch (choice)
                {

                     
                case 0:
                    Console.WriteLine($"Bullet capacity :{capacity},bullet count :{count},Fire Mode :{mode}");
                        break;
                    case 1:
                        
                        weapon.Shoot();
                      
                        break;
                    case 2:
                       
                        weapon.Fire();
                      
                        break;
                    case 3:
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        Console.WriteLine("_____________________________________________________");
                        break;
                    case 4:
                        Console.WriteLine("_____________________________________________________");
                        weapon.Reload();
                        Console.WriteLine("_____________________________________________________");
                        break;
                    case 5:
                        Console.WriteLine("_____________________________________________________");
                        weapon.ChangeFireMode();
                        Console.WriteLine("_____________________________________________________");
                        break;
                    case 6:
                        Console.WriteLine("_____________________________________________________");
                        Console.WriteLine("Program Stoped");
                        Console.WriteLine("_____________________________________________________");
                        break;
                    case 7:
                        Console.WriteLine("Change capacity\n Bullet Count\n Reset seconds");
                        string edit = Console.ReadLine();
                        if (edit == "Change capacity")
                        {
                            Console.WriteLine("Change Capacity");
                            weapon.ChangeCapacity(int.Parse(Console.ReadLine()));

                        }
                        else if (edit == "Bullet Count")
                        {
                            Console.WriteLine("Change bullet count");
                            weapon.ChangeCount(int.Parse(Console.ReadLine()));
                        }
                        else if (edit == "Reset seconds")
                        {
                            weapon.ResetSecond();
                        }
                        break;
                    default:
                        Console.WriteLine("make the right choice");
                        break;
                }

            
            } while (choice != 6);
        }
    
    }
}

using System;
using System.Diagnostics;


namespace TaskWeapon.Models
{
    internal class Weapon
    {

        private int _magazinesize { get; set; }
        private int _currentbulletcount { get; set; }
        private string _firemode { get; set; }


        public int MagazineSize { get; set; }
        public int CurrentbulletCount { get; set; }
        public string FireMode { get; set; }

        int numberofcalls = 1;
        int fire = -1;
        int count = 0;
        int reload = 0;

        // Shoot Method 
        public void Shoot()
        {
            if (CurrentbulletCount > 0)
            {

                Console.WriteLine(--CurrentbulletCount);
            }
            else
            {
                Console.WriteLine("You don't have any bullet");
            }
        }

        public void Fire()
        {
            fire = CurrentbulletCount - CurrentbulletCount;
            Console.WriteLine("bullets were fired, the number of bullets in the comb :" + fire);
        }

        public int GetRemainBulletCount()
        {
            if (CurrentbulletCount >= 0)
            {
                return MagazineSize - CurrentbulletCount;
            }
            return 0;
        }
        public void Reload()
        {

            reload = count + CurrentbulletCount;
            Console.WriteLine("comb filled :" + reload);
        }
        public void ChangeFireMode()
        {
            if (FireMode == "Automatic")
            {
                FireMode = "single";
            }
            else
            {
                FireMode = "Automatic";
            }
            Console.WriteLine(FireMode);
        }
        public void ChangeCapacity(int _capacity)
        {
            numberofcalls = _capacity;
            Console.WriteLine($"Capacity changed :{numberofcalls}");
        }
        public void ChangeCount(int _count)
        {
            CurrentbulletCount = _count;
            Console.WriteLine($"Count Changed :{CurrentbulletCount}");
        }
        public void ResetSecond()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            fire = CurrentbulletCount - CurrentbulletCount;
            Console.WriteLine("bullets were fired, the number of bullets in the comb :" + fire);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;


            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);


        }
    }
}


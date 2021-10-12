using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProject
{
    class Program
    {
        static int weapon = 0;
        static int weaponAmount = 5;
       
        static int[] ammoType = new int[weaponAmount];
        static string[] weaponType = new string[weaponAmount];





        static void Main(string[] args)
        {
            weaponType[0] = "Pistol";
            weaponType[1] = "Shotgun";
            weaponType[2] = "SMG";
            weaponType[3] = "BFG";
            weaponType[4] = "Rocket";

            ammoType[0] = 10;
            ammoType[1] = 6;
            ammoType[2] = 20;
            ammoType[3] = 200;
            ammoType[4] = 25;

            ShowHud();
            SwitchWeapon(1);
            ShowHud();
            Fire(2);
            ShowHud();
            Reload(ammoType[1] + weaponAmount);
            ShowHud();
            Console.ReadKey(true);


        }

        static void ShowHud()
        {
            Console.WriteLine(weaponType[weapon] + ": " + ammoType[weapon]);     
            
        }

        static void SwitchWeapon(int weaponToSwitch)
        {
            weapon = weaponToSwitch - 1;
            Console.WriteLine("Player switched to " + weaponType[weapon]);
        }

        static void Fire(int amount)
        {
            ammoType[weapon] = ammoType[weapon] - amount;
            Console.WriteLine("Player fired " + weaponType[weapon]);
        }

        static void Reload(int amount)
        {
            ammoType[weapon] = ammoType[weapon] + amount;
            Console.WriteLine("Player is reloading " + ammoType[weapon]);
        }
    }
}
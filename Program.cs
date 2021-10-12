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
        static int[] ammoMaxes = new int[weaponAmount];

        static int maxAmmo;





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

            ammoMaxes[0] = ammoType[0];
            ammoMaxes[1] = ammoType[1];
            ammoMaxes[2] = ammoType[2];
            ammoMaxes[3] = ammoType[3];
            ammoMaxes[4] = ammoType[4];

            ShowHud();
            SwitchWeapon(1);
            ShowHud();
            Fire(2);
            ShowHud();
            Reload(10);
            ShowHud();
            SwitchWeapon(4);
            ShowHud();
            Fire(5);
            ShowHud();
            Reload(5);             //Reload(100); tried to break code.
            ShowHud();
            Console.ReadKey(true);


        }

        static void ShowHud()
        {
            Console.WriteLine();
            Console.WriteLine("Player weapon: " + weaponType[weapon]);
            Console.WriteLine("Ammo for " + weaponType[weapon] + ": " + ammoType[weapon]);
            Console.WriteLine();
            
        }

        static void SwitchWeapon(int weaponToSwitch)
        {
            weapon = weaponToSwitch;
            Console.WriteLine("Player switched to " + weaponType[weapon]);
        }

        static void Fire(int amount)
        {
            ammoType[weapon] = ammoType[weapon] - amount;
            if (ammoType[weapon] <= 0)
            {
                ammoType[weapon] = 0;
            }
            Console.WriteLine("Player fired " + amount + " " + weaponType[weapon] + " bullets");
        }

        static void Reload(int amount)
        {
         
            ammoType[weapon] = ammoType[weapon] + amount;
            if (ammoType[weapon] >= ammoMaxes[weapon])
            {
                ammoType[weapon] = ammoMaxes[weapon];
            }
            Console.WriteLine("Player is reloading " + ammoType[weapon] + " bullets for " + weaponType[weapon]);
        }
    }
}
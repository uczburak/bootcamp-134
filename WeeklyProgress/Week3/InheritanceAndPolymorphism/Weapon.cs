﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Weapon
    {
        public int Weight { get; set; }
        public int HitPoint { get; set; }
        public virtual void Attack()
        {
            Console.WriteLine($"Tabanca ile saldırdı.");
        }
    }

    public class Knife : Weapon
    {
    }

    public class Gun : Weapon
    {
        public int BulletsCount { get; set; }
        public int MaxCharger { get; set; }
        public void ChangeCharger()
        {
            Console.WriteLine($" Tabancanın şarjörü değişti.");
        }
    }

    public class DesertEagle : Gun
    {
    }

    public class Sniper : Gun
    {
        public int Distance { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Sniper ile saldırıldı.");
        }
    }

    public class MachineGun : Gun
    {
        public bool Zoom { get; set; }
    }


    public class Ak47 : MachineGun
    {
        public override void Attack()
        {
            Console.WriteLine($"AK47 ile saldırıldı.");
        }
    }

    public class Shotgun : Gun
    {
        public int SpesificProperty { get; set; }
    }
}

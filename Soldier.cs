using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janecek_20221212
{
    public class Soldier
    {
    
        private int dovednost;
        private int heals;
        private int dmg;

        
        public string Jmeno { get; set; }
        public int Zivot { get; set; }
        public int MaxZivot { get; set; }
        public int Shield { get; set; }
        public int MaxShield { get; set; }
        public int Dovednost { get => dovednost; }
        public int Heals { get => heals; }
        public int Dmg { get => dmg; }
        public int Level { get; set; }



        public Soldier()
        {
            Random rand = new Random();

            Jmeno = "";
            Zivot = 100;
            MaxZivot = 100;
            Shield = 100;
            MaxShield= 100;
            dovednost = 0;
            heals = 5;
            dmg = rand.Next(30, 58);
            Level = 1;
        }



        public void ZvysitDovednost()
        {
            Zivot += 30;
            MaxZivot += 10;
            dovednost += 1;
            if (Shield < MaxShield)
            {
                Shield = MaxShield;
            }
        }
        public void Attack()
        {
            if (Shield > 0 && Level ==1)
            {
                Shield -= dmg; 
            }
            else if (Shield > 0 && Level == 2)
            {
                Shield -= dmg -10;
            }
            else if (Shield > 0 && Level == 3)
            {
                Shield -= dmg - 20;
            }
            else if (Shield > 0 && Level == 4)
            {
                Shield -= dmg - 30;
                
            }
            else if (Shield > 0 && Level == 5)
                {
                    Shield -= dmg - 40;
                }
            else if (Shield <= 0 && Level == 1)
            {
               Zivot -= dmg ;
            }
            else if (Shield <= 0 && Level == 2)
            {
                Zivot -= dmg - 10;
            }
            else if (Shield <= 0 && Level == 3)
            {
                Zivot -= dmg  - 20;
            }
            else if (Shield <= 0 && Level == 4)
            {
                Zivot -= dmg - 30;
            }
            else if (Shield <= 0 && Level == 5)
            {
                Zivot -= dmg - 40;
            }

        }

        
        public void Heal()
        {
            if (Zivot > 0)
            {
              Zivot +=50;
            }

        }
    }
}

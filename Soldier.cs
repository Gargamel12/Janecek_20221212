using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janecek_20221212
{
    public class Soldier
    {
        // soukromé proměnné - nejsou dostupné mimo třídu Clovek
        private int energie;
        private int dovednost;
        private int heals;
        private int momentalnienerzy;
        private int dmg;

        // vlastnosti - zveřejňují hodnoty ven z třídy
        public string Jmeno { get; set; }
        public int Zivot { get; set; }
        public int MaxZivot { get; set; }
        public int Shield { get; set; }
        public int MaxShield { get; set; }
        public int Dovednost { get => dovednost; }
        public int Heals { get => heals; }
        public int Dmg { get => dmg; }


        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy
        public Soldier()
        {
            Jmeno = "";
            Zivot = 100;
            Shield = 100;
            dovednost = 0;
            heals = 5;
            dmg = 0;
        }



        public void ZvysitDovednost()
        {
            Zivot += 30;
            MaxZivot += 10;
            dovednost += 1;
            dmg += 10;
        }
        public void Attack()
        {
            { 
                Zivot -= Dmg;
            }
            

        }

        }
        public void Heals()
        {
            if (Zivot > 0)
            {
             Zivot +=5;
            }

        }
    }
}

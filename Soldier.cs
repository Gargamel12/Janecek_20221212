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
        private int drinks;
        private int momentalnienerzy;
        private int dmg;

        // vlastnosti - zveřejňují hodnoty ven z třídy
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Energie { get => energie; }
        public int Zivot { get; set; }
        public int Dovednost { get => dovednost; }
        public int Drinks { get => drinks; }
        public int Dmg { get => dmg; }


        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy
        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
            drinks = 5;
            dmg = 0;
        }


        public void PosunoutCas()
        {
            energie += 20;
            Zivot += 5;
        }

        public void ZvysitDovednost()
        {
            Zivot += 20;
            dovednost += 10;
            energie += 10;
            dmg += 10;
        }
        public void Attack()
        {
            if (energie < 0)
            {
                Zivot -= 0;
            }
            else if (energie > 0)
            {
                Zivot -= 10;
                Zivot -= Dmg;
            }
            else if (energie < 0)
            {
                Zivot = 0;
            }
            else if (Zivot <= 0)
            {
                Zivot -= 0;
            }

        }
        public void Enerzy()
        {
            energie -= 20;
            if (energie < 0)
            {
                energie = 0;
                Zivot -= 5;
            }
            else if (Zivot <= 0)
            {
                Zivot -= 0;
            }

        }
        public void Drink()
        {
            if (Zivot > 0)
            {
                momentalnienerzy = energie;
                if (energie > 100)
                {
                    energie = 100;

                }
                if (drinks <= 0)
                {
                    energie = momentalnienerzy;
                    drinks = 0;
                }
                if (energie < 100)
                {
                    energie += 50;
                    drinks -= 1;
                }
            }
            else
            {
                energie = -0;
            }


        }
    }
}

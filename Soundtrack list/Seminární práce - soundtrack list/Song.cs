using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminární_práce___soundtrack_list
{
    public class Song
    {
        public int ID;
        public string NAZEV;
        public string AUTOR;
        public int DELKA;
        public double PORADI;
        public double PLAY;


        public Song(int idcko, string tvoritel, string name, int time, double row, double pp = 0)
        {
            ID = idcko;
            AUTOR = tvoritel;
            NAZEV = name;
            DELKA = time;
            PORADI = row;
            PLAY = pp;
        }


        public override string ToString()
        {
            if (AUTOR == "Toto")
            return AUTOR + "\t\t" +NAZEV;
            if (AUTOR == "Europe")
            return AUTOR + "\t\t" + NAZEV;
            return AUTOR + "\t" + NAZEV;
        }

    }
}

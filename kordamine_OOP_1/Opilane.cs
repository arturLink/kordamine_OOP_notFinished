using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_OOP_1
{
    public class Opilane : Isik
    {
        public string kooliNimi;
        public enum Kursus { First,Second,Third }
        Kursus kursus;
        public enum Spetsialiseerumine { Ehitaja,Developer,IT }
        Spetsialiseerumine spetsialiseerumine;
        
        public string city;
        public int fMembers;
        public double averageGrade;

        Opilane() { }
        Opilane(string nimi, int synniAasta, sugu Sugu, string city,int fMembers, string kooliNimi, Kursus kursus, Spetsialiseerumine spetsialiseerumine) : base(nimi, synniAasta, Sugu)
        {
            this.fMembers = fMembers;
            this.city = city;
            this.kooliNimi = kooliNimi;
            this.kursus = kursus;
            this.spetsialiseerumine = spetsialiseerumine;
        }

        /*
        public int Toetus()
        {
            int soidutoetus=0;
            int pohitoetus=0;
            int eritoetus = 0;
            int koostoetus = 0;
            if (city=="Tallinn")
            {
                soidutoetus = 0;
            }
            else
            {
                soidutoetus = 20;
            }
            if (averageGrade>3.5)
            {
                pohitoetus = 60;
            }
            else
            {
                pohitoetus=0;
            }
         
        }
        */
    }
}

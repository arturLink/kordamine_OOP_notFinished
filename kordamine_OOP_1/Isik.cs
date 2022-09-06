﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_OOP_1
{
    public abstract class Isik
    {
        //peremenii
        public string nimi;
        public int synniAasta;
        public enum sugu { mees, naine};
        public sugu Sugu;

        //construktori
        public Isik()
        {

        }

        public Isik(string nimi, int synniAasta, sugu Sugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
        }

        //methods

        public void PRINTinfo()
        {
            Console.WriteLine("Mina olen {0}, minu synni aasta on {1} ja ma olen {2}", nimi, synniAasta, Sugu);
        }

        public int ArvutaVanus()
        {
            return DateTime.Now.Year - synniAasta;
        }

        public void muudaNimi(string uusNimi)
        {
            nimi = uusNimi;
        }



    }
}

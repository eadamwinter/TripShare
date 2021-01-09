using System;

namespace TripShare
{
    public class Expense
    {
        public byte idTabeli;
        public string imie;
        public double wydatek;

        public Expense(byte idTabeli, string imie, double wydatek)
        {
            this.idTabeli = idTabeli;
            this.imie = imie;
            this.wydatek = wydatek;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PeksekEladas
{
    public class pekaru
    {
        public string Nev { get; set; }
        public int Egysegar { get; set; }
        public int EladottDb { get; set; }
        public pekaru(string sor)
        {
            string[] darabol = sor.Split(";");
            Nev = darabol[0];
            Egysegar = int.Parse(darabol[1]);
            EladottDb= int.Parse(darabol[2]);
        }
        public override string ToString()
        {
            return $"{Nev}: {EladottDb} db ({Egysegar} Ft/db) - Bevétel: {EladottDb*Egysegar} Ft";
        }
    }
}

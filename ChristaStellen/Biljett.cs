using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristaStellen
{
    class Biljett
    {
        public string Namn { get; set; }
        public double Pris { get; set; }
        public int Antal{get;set;}

        public override string ToString()
        {
            return Antal + " st " + Namn + " " + Pris + " kr".ToString();
        }
    }
}

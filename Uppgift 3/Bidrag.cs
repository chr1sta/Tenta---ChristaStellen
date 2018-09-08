using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Bidrag
    {
        public int Startnummer { get; set; }
        public string Land { get; set; }
        public string Artist { get; set; }
        public string Sång { get; set; }
        public string Språk { get; set; }
        public int Placering { get; set; }
        public int Poäng { get; set; }

        public override string ToString()
        {
            return Startnummer + "\t" + Sång + "\t" + Poäng + " p".ToString();
        }

        //public int bidrag(int antalröster)//https://msdn.microsoft.com/en-us/library/system.math.round(v=vs.110).aspx#Round2_Example
        //{
        //    int totaltAntal = 1500;
        //    double andel = antalröster / totaltAntal;
        //    double poäng = andel * 473;
        //    double avrundning = Math.Round(poäng);
        //}
    }
}

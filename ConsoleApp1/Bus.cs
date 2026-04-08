using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Bus : Kendaraan //bus turunan dari kendaraan
    {
        public Bus(int laju) : base(laju, 40) { }
        public override void Jalan(trafficLight s)
        {
            if (s.Status == "Merah") this.Kecepatan = 0;
            Console.WriteLine($"Bus melaju {this.Kecepatan} km/jam di jalur kiri.");
        }
    }
}
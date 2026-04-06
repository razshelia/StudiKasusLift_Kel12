using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Mobil : Kendaraan
    {
        public Mobil(int laju) : base(laju, 60) { }
        public override void Jalan(Lampu s)
        {
            if (s.Status == "Merah") this.Kecepatan = 0;
            Console.WriteLine($"Mobil melaju {this.Kecepatan} km/jam.");
        }
    }

}

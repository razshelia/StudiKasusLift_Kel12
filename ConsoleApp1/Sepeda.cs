using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Sepeda : Kendaraan
    {
        public Sepeda(int laju) : base(laju, 20) { }
        public override void Jalan(Lampu s)
        {
            if (s.Status == "Merah") this.Kecepatan = 0;
            Console.WriteLine($"Sepeda melaju {this.Kecepatan} km/jam di jalur khusus.");
        }
    }
}


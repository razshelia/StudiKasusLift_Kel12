using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Motor : Kendaraan
    {
        public Motor(int laju) : base(laju, 50) { }
        public override void Jalan(Lampu s)
        {
            if (s.Status == "Merah") this.Kecepatan = 0;
            Console.WriteLine($"Motor melaju {this.Kecepatan} km/jam.");
        }
    }
}

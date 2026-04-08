using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Motor : Kendaraan
    {
        public Motor(int laju) : base(laju, 50) { }
        public override void Jalan(trafficLight s)
        {
            if (s.Status == "Merah")
            {
                this.Menepi();
            }
            if (s.Status == "Hijau")
            {
                Console.WriteLine($"{this.GetType().Name} melaju {this.Kecepatan} km/jam.");
            }
            else
            {
                return;
            }
        }
    }
}
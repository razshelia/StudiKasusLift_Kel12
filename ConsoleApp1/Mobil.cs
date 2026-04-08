using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Mobil : Kendaraan
    {
        public Mobil(int kecepatan) : base(kecepatan, 60) { }
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
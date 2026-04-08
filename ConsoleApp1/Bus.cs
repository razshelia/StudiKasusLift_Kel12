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
            if (s.Status == "Merah")
            {
                this.Menepi();
            }
            if (s.Status == "Hijau")
            {
                Console.WriteLine($"Bus melaju {this.Kecepatan} km/jam di jalur kiri.");
            }
            else
            {
                return; // Jika lampu bukan Merah atau Hijau, bus tetap pada posisinya (tidak melakukan apa-apa)
            }
        }
    }
}
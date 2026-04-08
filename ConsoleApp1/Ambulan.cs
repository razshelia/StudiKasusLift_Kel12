using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Ambulan : Darurat
    {
        public Ambulan(int kecepatan, bool s) : base(kecepatan, 100, s) { } //s adalah nilai dari parameter trafficLight
        public override void Jalan(trafficLight s) //status traficlight-nya apa Merah, Kuning, Hijau
        {
            string aksi = this.IsAktif ? "MENEROBOS" : "IKUT";
            Console.WriteLine($"Ambulan {aksi} lampu {s.Status}."); //aksi= menerobos atau mengikuti
        }
    }
}
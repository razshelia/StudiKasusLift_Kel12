using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Ambulan : Darurat
    {
        public Ambulan(int laju, bool s) : base(laju, 100, s) { }
        public override void Jalan(Lampu s)
        {
            string aksi = this.IsAktif ? "MENEROBOS" : "IKUT";
            Console.WriteLine($"Ambulan {aksi} lampu {s.Status}.");
        }
    }
}

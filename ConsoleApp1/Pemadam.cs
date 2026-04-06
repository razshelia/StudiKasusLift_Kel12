using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Pemadam : Darurat
    {
        public Pemadam(int laju, bool s) : base(laju, 80, s) { }
        public override void Jalan(Lampu s)
        {
            string aksi = this.IsAktif ? "MENEROBOS" : "IKUT";
            Console.WriteLine($"Pemadam {aksi} lampu {s.Status}..");
        }
    }
}

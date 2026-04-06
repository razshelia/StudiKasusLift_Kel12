using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public abstract class Darurat : Kendaraan
    {
        private bool Sirine;

        public bool IsAktif
        {
            get { return this.Sirine; }
            set { this.Sirine = value; }
        }

        public Darurat(int laju, int max, bool sirine) : base(laju, max)
        {
            this.IsAktif = sirine;
        }

        // Override Menepi: Kendaraan darurat tidak perlu menepi
        public override void Menepi() { }
    }
}


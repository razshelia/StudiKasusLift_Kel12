using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class trafficLight
    {
        // Atribut (Private Fields)
        private string Warna = "Merah"; // Merah, Kuning, Hijau

        // Encapsulation (Property)
        public string Status
        {
            get { return this.Warna; }
            set { this.Warna = value; }
        }

        // Constructor
        public trafficLight(string Warna)
        {
            this.Status = Warna;
        }
    }
}
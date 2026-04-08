using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Orang
    {
        private string Nama;

        public Orang(string nama)
        {
            this.Nama = nama;
        }

        // Method dengan parameter objek Lampu
        public void Jalan(trafficLight s)
        {
            // Logika: Hanya menyeberang jika lampu Merah (bagi kendaraan)
            if (s.Status == "Merah")
                Console.WriteLine($"{this.Nama} sedang menyeberang di Zebra Cross.");
            else
                Console.WriteLine($"{this.Nama} menunggu di pinggir jalan.");
        }
    }
}
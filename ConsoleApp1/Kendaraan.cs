using System;
using System.Collections.Generic;
using System.Text;

namespace StudiKasusLaluLintas_Kel_12
{
    public abstract class Kendaraan
    {
        // --- ATRIBUT (Private Fields) ---
        private int Laju;
        private int Max;

        // --- ENCAPSULATION (Property dengan Validasi) ---
        public int Kecepatan
        {
            get { return this.Laju; }
            set
            {
                // Cek apakah nilai yang dimasukkan melebihi batas Max
                if (value > this.Max)
                {
                    // MEMBERIKAN PERINGATAN (Sangat bagus untuk pengujian)
                    Console.WriteLine($"[!] PERINGATAN: {this.GetType().Name} tidak boleh melaju {value} km/jam! (Batas: {this.Max}).");
                    this.Laju = this.Max; // Kecepatan dipaksa ke batas maksimal
                }
                else
                {
                    this.Laju = value;
                }
            }
        }

        // --- CONSTRUCTOR ---
        public Kendaraan(int laju, int max)
        {
            this.Max = max;
            // Kita panggil Properti (Kecepatan), bukan field (Laju) 
            // agar validasi 'set' di atas langsung berjalan saat objek dibuat.
            this.Kecepatan = laju;
        }

        // --- METHOD (Polimorfisme) ---
        public abstract void Jalan(trafficLight s);

        public virtual void Menepi()
        {
            this.Kecepatan = 0;
            Console.WriteLine($"{this.GetType().Name} melambat dan menepi..");
        }
    }
}
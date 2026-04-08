using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudiKasusLaluLintas_Kel_12
{
    class Program
    {
        static void Main()
        {
            trafficLight rambu = new trafficLight("Hijau");

            // Di sini kita set sirine secara spesifik per objek
            List<Kendaraan> jalanan = new List<Kendaraan>
        {
            new Mobil(100),
            new Motor(40),
            new Bus(30),
            new Sepeda(15),
            new Ambulan(90, true),
            new Pemadam(70, false)
        };

            Orang pejalan = new Orang("Budi");

            // CEK OTOMATIS: Apakah ada kendaraan darurat yang sedang aktif sirinenya?
            bool bahaya = jalanan.OfType<Darurat>().Any(d => d.IsAktif);

            Console.WriteLine($"--- STATUS JALAN: {rambu.Status} ---");

            foreach (Kendaraan k in jalanan)
            {
                // Jika ada kendaraan darurat yang AKTIF, kendaraan lain menepi
                if (bahaya && !(k is Darurat))
                {
                    k.Menepi();
                }
                // Jika dia adalah Darurat tapi sirinenya MATI, dia ikut aturan lampu biasa
                else if (k is Darurat d && !d.IsAktif)
                {
                    k.Jalan(rambu);
                }
                // Jika dia Darurat AKTIF atau kondisi aman, jalankan normal
                else
                {
                    k.Jalan(rambu);
                }
            }

            pejalan.Jalan(rambu);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudiKasusLaluLintas_Kel_12
{
    class Program
    {
        static void Main()
        {
            // 1. Pembuatan Objek
            List<Kendaraan> jalanan = new List<Kendaraan>
            {
                new Mobil(100),
                new Motor(40),
                new Bus(30),
                new Sepeda(15),
                new Ambulan(90, false), // Sirine MATI
                new Pemadam(70, true)   // Sirine NYALA
            };

            Orang pejalan = new Orang("Budi");

            // Cek apakah ada kendaraan darurat yang sirinenya nyala di jalanan tersebut
            bool bahaya = jalanan.OfType<Darurat>().Any(d => d.IsAktif);

            // SKENARIO 1: LAMPU HIJAU
            trafficLight rambuHijau = new trafficLight("Hijau");
            Console.WriteLine($"--- STATUS JALAN: LAMPU {rambuHijau.Status.ToUpper()} ---");

            foreach (Kendaraan k in jalanan)
            {
                k.Jalan(rambuHijau);
            }

            pejalan.Jalan(rambuHijau, bahaya);


            Console.WriteLine("\n---------------------------------------\n");


            // SKENARIO 2: LAMPU MERAH
            // (memastikan kecepatan kendaraan sipil masih ada sebelum dipaksa berhenti oleh lampu merah)
            jalanan[0].Kecepatan = 60; // Mobil
            jalanan[1].Kecepatan = 40; // Motor
            jalanan[2].Kecepatan = 30; // Bus
            jalanan[3].Kecepatan = 15; // Sepeda

            trafficLight rambuMerah = new trafficLight("Merah");
            Console.WriteLine($"--- STATUS JALAN: LAMPU {rambuMerah.Status.ToUpper()} ---");

            foreach (Kendaraan k in jalanan)
            {
                k.Jalan(rambuMerah);
            }
            pejalan.Jalan(rambuMerah, bahaya);

            Console.ReadLine();
        }
    }
}
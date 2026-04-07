using System;

namespace SimulasiLift
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. DATA GEDUNG
            string[] denahFasilkom = {
                "Lobby Parkir",       // Lantai 1 
                "Ruang Tata Usaha",   // Lantai 2
                "Lab Komputer",       // Lantai 3
                "Ruang Server"        // Lantai 4 (VIP)
            };
            int[] lantaiVip = { 4 };

            // 2. UPCASTING (POLIMORFISME)
            Lift liftTamu = new Orang("Lift Penumpang", 800, denahFasilkom, lantaiVip);
            Lift liftKargo = new Barang("Lift Barang", 3000, denahFasilkom, lantaiVip);

            // 3. UJI COBA ENKAPSULASI (BEBAN)
            Console.WriteLine("=== UJI COBA ENKAPSULASI MUATAN ===");
            liftKargo.TambahBeban(1000); // Aman
            liftKargo.TambahBeban(2500); // Ditolak karena 1000+2500 = 3500 > 3000

            // 4. UJI COBA OVERLOADING (HAK AKSES VIP)
            Console.WriteLine("\n=== UJI COBA OVERLOADING TIPE INPUT ===");
            liftTamu.TekanTombol(3);                  // Sukses (Tanpa kartu)
            liftTamu.TekanTombol(4);                  // Ditolak (Area VIP)
            liftTamu.TekanTombol(4, "KARTU-TEKNISI"); // Sukses (Pakai kartu valid)

            // 5. UJI COBA OVERRIDING (MATEMATIKA WAKTU TEMPUH)
            Console.WriteLine("\n=== UJI COBA OVERRIDING RUMUS MATEMATIKA ===");

            Console.WriteLine("[Persiapan: Menaikkan Lift Kargo ke Lantai 4]");
            liftKargo.TekanTombol(4, "KARTU-TEKNISI");

            Console.WriteLine("\n[Perbandingan Balapan Turun ke Lantai 1 (Jarak 3 lantai)]");

            liftTamu.TekanTombol(1);  
            liftKargo.TekanTombol(1); 

            Console.ReadLine();
        }
    }
}
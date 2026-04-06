using System;

namespace SimulasiLift
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. PERSIAPAN DENAH DAN BUKU VIP
            string[] denahFasilkom = {
                "Parkiran Motor",     // Lantai 1
                "Lobi Utama",         // Lantai 2
                "Lab Komputer",       // Lantai 3
                "Ruang Server",       // Lantai 4 (VIP)
                "Ruang Direktur"      // Lantai 5 (VIP)
            };

            string[] denahRuko = {
                "Lantai Dasar (Toko)", // Lantai 1
                "Lantai Dua (Gudang)", // Lantai 2
                "Lantai Tiga (Mess)"   // Lantai 3
            };

            // Membuat buku daftar VIP. Hanya dideklarasikan SATU KALI di sini.
            int[] tanpaVip = new int[0]; // Buku kosong
            int[] banyakVip = { 4, 5 };  // Buku berisi lantai 4 dan 5

            // 2. PEMBUATAN OBJEK LIFT

            // Lift Kargo di Fasilkom (Gedung besar, punya lantai VIP)
            Barang liftFasilkom = new Barang("Lift Fasilkom", 3000, denahFasilkom, banyakVip);

            // Lift Ruko (Gedung kecil, kita berikan buku 'tanpaVip' di sini)
            Orang liftRuko = new Orang("Lift Ruko Bebas", 500, denahRuko, tanpaVip);

            // 3. UJI COBA POLIMORFISME

            Console.WriteLine("=== SIMULASI LIFT DENGAN VIP (FASILKOM) ===");
            // Berhasil karena lantai 3 bukan VIP
            liftFasilkom.TekanTombol(3);

            // Ditolak karena lantai 4 adalah VIP (hanya tekan tombol)
            liftFasilkom.TekanTombol(4);

            // Berhasil masuk lantai 4 karena menempelkan kartu (Overloading)
            liftFasilkom.TekanTombol(4, "KARTU-TEKNISI");


            Console.WriteLine("\n=== SIMULASI LIFT TANPA VIP (RUKO) ===");
            // Langsung berhasil naik ke lantai paling atas karena tidak ada VIP di ruko ini
            liftRuko.TekanTombol(3);

            Console.ReadLine();
        }
    }
}
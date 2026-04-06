using System;

namespace SimulasiLift
{
    public class Orang : Lift
    {
        // UBAH DI SINI: Parameter terakhir sekarang adalah int[] daftarLantaiVip
        public Orang(string nama, int batasBeban, string[] daftarLantai, int[] daftarLantaiVip)
            : base(nama, batasBeban, daftarLantai, daftarLantaiVip) { }

        // OVERRIDING FUNGSI MATEMATIKA
        public override int HitungWaktuTempuh(int jarak)
        {
            // Lift Orang: Setiap 1 lantai butuh 2 detik
            int waktu = jarak * 2;
            return waktu;
        }
    }
}
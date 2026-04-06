using System;

namespace SimulasiLift
{
    public class Barang : Lift
    {
        // UBAH DI SINI: Parameter terakhir sekarang adalah int[] daftarLantaiVip
        public Barang(string nama, int batasBeban, string[] daftarLantai, int[] daftarLantaiVip)
            : base(nama, batasBeban, daftarLantai, daftarLantaiVip) { }

        // OVERRIDING FUNGSI MATEMATIKA
        public override int HitungWaktuTempuh(int jarak)
        {
            // Lift Barang: Setiap 1 lantai butuh 5 detik + waktu pemanasan hidrolik 4 detik
            int pemanasanMesin = 4;
            int waktu = (jarak * 5) + pemanasanMesin;
            return waktu;
        }
    }
}
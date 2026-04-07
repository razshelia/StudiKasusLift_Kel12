using System;

namespace SimulasiLift
{
    public class Barang : Lift
    {
        public Barang(string nama, int batasBeban, string[] daftarLantai, int[] daftarLantaiVip)
            : base(nama, batasBeban, daftarLantai, daftarLantaiVip) { }

        // OVERRIDING: Lift Barang berkecepatan rendah + jeda pemanasan hidrolik
        public override int HitungWaktuTempuh(int jarak)
        {
            int pemanasanMesin = 4;
            int waktu = (jarak * 5) + pemanasanMesin;
            return waktu;
        }
    }
}
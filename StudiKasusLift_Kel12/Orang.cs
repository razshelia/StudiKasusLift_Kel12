using System;

namespace SimulasiLift
{
    public class Orang : Lift
    {
        public Orang(string nama, int batasBeban, string[] daftarLantai, int[] daftarLantaiVip)
            : base(nama, batasBeban, daftarLantai, daftarLantaiVip) { }

        // OVERRIDING: Lift Penumpang berkecepatan tinggi
        public override int HitungWaktuTempuh(int jarak)
        {
            int waktu = jarak * 2;
            return waktu;
        }
    }
}
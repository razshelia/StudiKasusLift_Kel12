using System;

namespace SimulasiLift
{
    public abstract class Lift
    {
        private string nama;
        private int lantai;
        private int beban;
        private int batasBeban;
        private string[] daftarLantai;
        private int[] daftarLantaiVip;

        // CONSTRUCTOR
        public Lift(string nama, int batasBeban, string[] daftarLantai, int[] daftarLantaiVip)
        {
            this.nama = nama;
            this.batasBeban = batasBeban;
            this.daftarLantai = daftarLantai;
            this.daftarLantaiVip = daftarLantaiVip; 

            this.lantai = 1;
            this.beban = 0;
        }

        // PROPERTI (SATPAM DATA)
        public string Nama { get { return this.nama; } }
        public int BatasBeban { get { return this.batasBeban; } }
        public int Beban { get { return this.beban; } }

        public int Lantai
        {
            get { return this.lantai; }
            set
            {
                if (value >= 1 && value <= this.daftarLantai.Length)
                    this.lantai = value;
                else
                    Console.WriteLine($"  [SATPAM] Ditolak! Gedung ini hanya memiliki {this.daftarLantai.Length} lantai.");
            }
        }

        protected bool ApakahLantaiVip(int lantaiTujuan)
        {
            // Satpam membuka buku daftar VIP dari halaman awal sampai akhir
            for (int i = 0; i < this.daftarLantaiVip.Length; i++)
            {
                if (this.daftarLantaiVip[i] == lantaiTujuan)
                {
                    return true; // Ketemu! Ini lantai VIP.
                }
            }
            return false; // Buku habis dibaca dan tidak ketemu, berarti bukan VIP.
        }

        protected int HitungJarakPositif(int titikA, int titikB)
        {
            int hasil = titikA - titikB;
            if (hasil < 0) { hasil = hasil * -1; }
            return hasil;
        }

        public virtual int HitungWaktuTempuh(int jarak)
        {
            return jarak * 1;
        }

        // OVERLOADING 1: Tombol Biasa
        public void TekanTombol(int tuju)
        {
            Console.WriteLine($"\n[TOMBOL] Pengunjung menekan lantai {tuju}.");

            // Menggunakan method bantuan untuk mengecek status lantai
            if (this.ApakahLantaiVip(tuju) == true)
            {
                Console.WriteLine($"  [SISTEM] AKSES DITOLAK! Lantai {tuju} adalah area VIP. Harap Tap Kartu Akses!");
                return;
            }

            this.ProsesPindah(tuju);
        }

        // OVERLOADING 2: Tombol + Kartu
        public void TekanTombol(int tuju, string kodeKartu)
        {
            Console.WriteLine($"\n[TOMBOL + KARTU] Pengunjung menekan lantai {tuju} (Kartu: '{kodeKartu}').");

            if (this.ApakahLantaiVip(tuju) == true)
            {
                if (kodeKartu == "KARTU-BOS" || kodeKartu == "KARTU-TEKNISI")
                {
                    Console.WriteLine("  [SISTEM] Kartu Valid. Akses VIP Terbuka.");
                    this.ProsesPindah(tuju);
                }
                else
                {
                    Console.WriteLine("  [SISTEM] Kartu Tidak Dikenal! Akses Ditolak.");
                }
            }
            else
            {
                this.ProsesPindah(tuju);
            }
        }

        protected void ProsesPindah(int tuju)
        {
            int jarak = this.HitungJarakPositif(tuju, this.Lantai);
            if (jarak == 0) return;

            int estimasiDetik = this.HitungWaktuTempuh(jarak);

            this.Lantai = tuju;
            string namaRuang = this.daftarLantai[this.Lantai - 1];

            Console.WriteLine($"  -> Mesin bergerak... Waktu tempuh: {estimasiDetik} detik.");
            Console.WriteLine($"  -> Tiba di Lantai {this.Lantai} ({namaRuang}).");
        }
    }
}
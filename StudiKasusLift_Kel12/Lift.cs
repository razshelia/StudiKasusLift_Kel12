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

        public Lift(string nama, int batasBeban, string[] daftarLantai, int[] daftarLantaiVip)
        {
            this.nama = nama;
            this.batasBeban = batasBeban;
            this.daftarLantai = daftarLantai;
            this.daftarLantaiVip = daftarLantaiVip;
            this.lantai = 1;
            this.beban = 0;
        }

        public string Nama { get { return this.nama; } }
        public int BatasBeban { get { return this.batasBeban; } }
        public int Beban { get { return this.beban; } }

        public int Lantai
        {
            get { return this.lantai; }
            set
            {
                // Guard Clause: Tolak input lantai di luar batas gedung
                if (value < 1 || value > this.daftarLantai.Length)
                {
                    Console.WriteLine($"  [SATPAM] Ditolak! Gedung hanya memiliki {this.daftarLantai.Length} lantai.");
                    return;
                }
                this.lantai = value;
            }
        }

        protected bool ApakahLantaiVip(int lantaiTujuan)
        {
            for (int i = 0; i < this.daftarLantaiVip.Length; i++)
            {
                if (this.daftarLantaiVip[i] == lantaiTujuan) return true;
            }
            return false;
        }

        protected int HitungJarakPositif(int titikA, int titikB)
        {
            int hasil = titikA - titikB;
            if (hasil < 0) { hasil = hasil * -1; }
            return hasil;
        }

        // OVERRIDING TARGET: Rumus waktu tempuh mesin
        public virtual int HitungWaktuTempuh(int jarak)
        {
            return jarak * 1;
        }

        public void TambahBeban(int berat)
        {
            // Guard Clause: Tolak jika melebihi kapasitas
            if (this.beban + berat > this.batasBeban)
            {
                Console.WriteLine("  [SISTEM] Overload! Beban melebihi kapasitas.");
                return;
            }
            this.beban += berat;
            Console.WriteLine($"  [SISTEM] Beban masuk. Total sekarang: {this.beban} kg");
        }

        // OVERLOADING 1: Tombol Biasa
        public void TekanTombol(int tuju)
        {
            Console.WriteLine($"\n[TOMBOL] Menekan lantai {tuju}.");

            if (this.ApakahLantaiVip(tuju) == true)
            {
                Console.WriteLine($"  [SISTEM] AKSES DITOLAK! Lantai {tuju} area VIP. Harap tap kartu!");
                return;
            }

            this.ProsesPindah(tuju);
        }

        // OVERLOADING 2: Tombol + Kartu Akses
        public void TekanTombol(int tuju, string kodeKartu)
        {
            Console.WriteLine($"\n[TOMBOL + KARTU] Menekan lantai {tuju} (Kartu: '{kodeKartu}').");

            // Guard Clause 1: Jika bukan area VIP, jalankan normal tanpa cek kartu
            if (this.ApakahLantaiVip(tuju) == false)
            {
                this.ProsesPindah(tuju);
                return;
            }

            // Guard Clause 2: Jika area VIP tapi kartu salah, tolak
            if (kodeKartu != "KARTU-BOS" && kodeKartu != "KARTU-TEKNISI")
            {
                Console.WriteLine("  [SISTEM] Kartu Tidak Dikenal! Akses Ditolak.");
                return;
            }

            // Lolos semua validasi
            Console.WriteLine("  [SISTEM] Kartu Valid. Akses VIP Terbuka.");
            this.ProsesPindah(tuju);
        }

        protected void ProsesPindah(int tuju)
        {
            if (tuju < 1 || tuju > this.daftarLantai.Length) return;

            int jarak = this.HitungJarakPositif(tuju, this.Lantai);
            if (jarak == 0) return;

            // Polimorfisme: Memanggil rumus waktu tempuh sesuai jenis kelas turunannya
            int estimasiDetik = this.HitungWaktuTempuh(jarak);

            this.Lantai = tuju;
            string namaRuang = this.daftarLantai[this.Lantai - 1];

            Console.WriteLine($"  -> Mesin bergerak... Waktu tempuh: {estimasiDetik} detik.");
            Console.WriteLine($"  -> Tiba di Lantai {this.Lantai} ({namaRuang}).");
        }
    }
}
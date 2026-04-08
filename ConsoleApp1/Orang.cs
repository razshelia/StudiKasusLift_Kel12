using System;

namespace StudiKasusLaluLintas_Kel_12
{
    public class Orang
    {
        private string Nama;

        public Orang(string nama)
        {
            this.Nama = nama;
        }

        public void Jalan(trafficLight sinyal, bool adaDarurat)
        {
            if (sinyal.Status == "Merah" && adaDarurat == false)
            {
                Console.WriteLine($"{this.Nama} sedang menyeberang di Zebra Cross dengan aman.");
            }
            else if (sinyal.Status == "Merah" && adaDarurat == true)
            {
                Console.WriteLine($"{this.Nama} membatalkan penyeberangan dan mundur ke trotoar karena ada Kendaraan Darurat!");
            }
            else
            {
                Console.WriteLine($"{this.Nama} menunggu di pinggir jalan karena kendaraan sedang melaju.");
            }
        }
    }
}
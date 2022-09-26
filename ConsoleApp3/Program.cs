using System;

namespace SimpleApp
{
    class ProgramSubclass
    {
        static void Main(string[] args)
        {
            ProgramSubclass apk = new ProgramSubclass();
            Console.WriteLine("Sedan");
            apk.constructor();
            Console.WriteLine("Truk");
            apk.conjungsi();
            Console.WriteLine("SepedaMotor");
            apk.assembly();
        }

        class Otomobil
        {
            public int kecepatan;
            public string merkotomobil;
        }
        class Sedan : Otomobil
        {
            public string nama;
            public string kesan;

            public void KecepatanOtomobil(int kecepatan)
            {
                this.kecepatan = kecepatan;
            }
            public void MerkOtomobil(string merkotomobil)
            {
                this.merkotomobil = merkotomobil;
            }
            public void namaMesin(string nama)
            {
                this.nama = nama;
            }
            public void Kesansedan(string kesan)
            {
                this.kesan = kesan;
            }
        }
        class Truk : Otomobil
        {
            public int kapasitas;
            public int roda;
            public void KecepatanOtomobil(int kecepatan)
            {
                this.kecepatan = kecepatan;
            }
            public void MerkOtomobil(string merkotomobil)
            {
                this.merkotomobil = merkotomobil;
            }
            public void KapasitasTruk(int kapasitas)
            {
                this.kapasitas = kapasitas;
            }
            public void RodaTruk(int roda)
            {
                this.roda = roda;
            }
        }
        class SepedaMotor : Otomobil
        {
            public int kapasitas;
            public string simple;
            public string irit;
            public void KecepatanOtomobil(int kecepatan)
            {
                this.kecepatan = kecepatan;
            }
            public void MerkOtomobil(string merkotomobil)
            {
                this.merkotomobil = merkotomobil;
            }
            public void Simple(string simple)
            {
                this.simple = simple;
            }
            public void Irit(string irit)
            {
                this.irit = irit;
            }
        }
        public void constructor()
        {
            Sedan sedan1 = new Sedan();
            sedan1.KecepatanOtomobil(200);
            Console.WriteLine("Kecepatan Otomobil:" + sedan1.kecepatan);
            sedan1.MerkOtomobil("Honda");
            Console.WriteLine("Merk Otomobil:" + sedan1.merkotomobil);
            sedan1.namaMesin("TurboCharger");
            Console.WriteLine("Salah Satu Mesin Yang Dipake Mobil Sedan:" + sedan1.nama);
            sedan1.Kesansedan("Mewah");
            Console.WriteLine("Kesan Mobil Sedan:" + sedan1.kesan);
        }
        public void conjungsi()
        {
            Truk truk1 = new Truk();
            truk1.KecepatanOtomobil(100);
            Console.WriteLine("Kecepatan Otomobil:" + truk1.kecepatan);
            truk1.MerkOtomobil("Honda");
            Console.WriteLine("Merk Otomobil:" + truk1.merkotomobil);
            truk1.KapasitasTruk(500);
            Console.WriteLine("Kapasitas Truk:" + truk1.kapasitas);
            truk1.RodaTruk(8);
            Console.WriteLine("Jumlah Roda Truk:" + truk1.roda);
        }
        public void assembly()
        {
            SepedaMotor sepedamotor1 = new SepedaMotor();
            sepedamotor1.KecepatanOtomobil(80);
            Console.WriteLine("Kecepatan Otomobil:" + sepedamotor1.kecepatan);
            sepedamotor1.MerkOtomobil("Honda");
            Console.WriteLine("Merk Otomobil:" + sepedamotor1.merkotomobil);
            sepedamotor1.Simple("Mudah dibawa");
            Console.WriteLine("Sepeda Motor Simple:" + sepedamotor1.simple);
            sepedamotor1.Irit("Irit Bensin");
            Console.WriteLine("Sepeda Motor Irit:" + sepedamotor1.irit);
        }

    }
}
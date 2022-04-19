using System;

namespace ResponsiPemrogramann4265

{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(19112712, "Slamet", 5000000);
            Karyawan karyawan2 = new Karyawan(19112712, "Reza", 20000000);

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Bahagianya Naik Gaji");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    internal class Karyawan
    {
        private int v1;
        private string v2;
        private int v3;

        public Karyawan(int v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Program
    {
        public static void Main()
        {

            Manager tegar = new Manager("Manager Drilling");
            Manager haidar = new Manager("Manager Drilling");
            Manager sani = new Manager("Manager Refinery");
            Manager adi = new Manager("Manager General Affairs");

            Supervisor iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor dani = new Supervisor("Supervisor Refinery Balikpapan");

            Staff dwi = new Staff("Staff Drilling Riau 1");
            Staff trio = new Staff("Staff Drilling Riau 2");
            Staff nuragus = new Staff("Staff Drilling Luwuk");
            Staff sofi = new Staff("Staff Refinery Balikpapan");
            Staff seta = new Staff("Staff General Affairs");


            tegar._nama = "Tegar";
            tegar._tanggalMasukKerja = "1 Desember 2015";
            tegar._gajiPokok = 3000000;
            tegar._tunjanganKaryawan = 500000;
            tegar._tunjanganPenginapan = 900000;
            tegar._tunjanganInternet = 200000;
            tegar._tunjanganHariRaya = 1000000;
            tegar._tunjanganStudyBanding = 900000;
            tegar._tunjanganKesehatan = 100000;


            haidar._nama = "Haidar";
            haidar._tanggalMasukKerja = "1 Desember 2012";
            haidar._gajiPokok = 3000000;
            haidar._tunjanganKaryawan = 500000;
            haidar._tunjanganPenginapan = 800000;
            haidar._tunjanganInternet = 400000;
            haidar._tunjanganHariRaya = 1000000;
            haidar._tunjanganStudyBanding = 1000000;
            haidar._tunjanganKesehatan = 100000;

            iqbal._nama = "Iqbal";
            iqbal._tanggalMasukKerja = "1 Desember 2013";
            iqbal._gajiPokok = 3000000;
            iqbal._tunjanganKaryawan = 1000000;
            iqbal._tunjanganPenginapan = 800000;
            iqbal._tunjanganInternet = 200000;

            dani._nama = "Dhani";
            dani._tanggalMasukKerja = "1 Desember 2015";
            dani._gajiPokok = 3000000;
            dani._tunjanganKaryawan = 500000;
            dani._tunjanganPenginapan = 800000;
            dani._tunjanganInternet = 200000;


            dwi._nama = "Dwi";
            dwi._tanggalMasukKerja = "1 Desember 2015";
            dwi._gajiPokok = 3000000;
            dwi._tunjanganKaryawan = 500000;
            

            trio._nama = "Trio";
            trio._tanggalMasukKerja = "1 Desember 2015";
            trio._gajiPokok = 3000000;
            trio._tunjanganKaryawan = 500000;


            Console.WriteLine("Sistem Karyawan Sisikaryakan");
            Console.WriteLine("Pilih Data Karyawan yang ingin dicetak  (Masukan Angka): ");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Supervisor");
            Console.WriteLine("3. Staff");
            string Angka = Console.ReadLine();

            
            if (Angka == "1")
            {
                Console.WriteLine("Nama : " + haidar._nama);
                Console.WriteLine("Jabatan : " + haidar._jabatan);
                Console.WriteLine("Tanggal Masuk Kerja : " + haidar._tanggalMasukKerja);
                Console.WriteLine("Gaji Pokok : " + haidar._gajiPokok);
                Console.WriteLine("Tunjangan Karyawan : " + haidar._tunjanganKaryawan);
                Console.WriteLine("Tunjangan Penginapan : " + haidar._tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + haidar._tunjanganInternet);
                Console.WriteLine("Tunjangan Hari Raya: " + haidar._tunjanganHariRaya);
                Console.WriteLine("Tunjangan Kesehatan : " + haidar._tunjanganKesehatan + Environment.NewLine);

                Console.WriteLine("Nama : " + tegar._nama);
                Console.WriteLine("Jabatan : " + tegar._jabatan);
                Console.WriteLine("Tanggal Masuk Kerja : " + tegar._tanggalMasukKerja);
                Console.WriteLine("Gaji Pokok : " + tegar._gajiPokok);
                Console.WriteLine("Tunjangan Karyawan : " + tegar._tunjanganKaryawan);
                Console.WriteLine("Tunjangan Penginapan : " + tegar._tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + tegar._tunjanganInternet);
                Console.WriteLine("Tunjangan Hari Raya: " + tegar._tunjanganHariRaya);
                Console.WriteLine("Tunjangan Kesehatan : " + tegar._tunjanganKesehatan + Environment.NewLine);
                Console.ReadLine();
            }
            if  (Angka == "2"){

                Console.WriteLine("Nama : " + iqbal._nama);
                Console.WriteLine("Jabatan : " + iqbal._jabatan);
                Console.WriteLine("Tanggal Masuk Kerja : " + iqbal._tanggalMasukKerja);
                Console.WriteLine("Gaji Pokok : " + iqbal._gajiPokok);
                Console.WriteLine("Tunjangan Karyawan : " + iqbal._tunjanganKaryawan);
                Console.WriteLine("Tunjangan Penginapan : " + iqbal._tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + iqbal._tunjanganInternet + Environment.NewLine);

                Console.WriteLine("Nama : " + dani._nama);
                Console.WriteLine("Jabatan : " + dani._jabatan);
                Console.WriteLine("Tanggal Masuk Kerja : " + dani._tanggalMasukKerja);
                Console.WriteLine("Gaji Pokok : " + dani._gajiPokok);
                Console.WriteLine("Tunjangan Karyawan : " + dani._tunjanganKaryawan);
                Console.WriteLine("Tunjangan Penginapan : " + dani._tunjanganPenginapan);
                Console.WriteLine("Tunjangan Internet: " + dani._tunjanganInternet + Environment.NewLine);
                Console.ReadLine();
            }
            if (Angka == "3")
            {
                Console.WriteLine("Nama : " + dwi._nama);
                Console.WriteLine("Jabatan : " + dwi._jabatan);
                Console.WriteLine("Tanggal Masuk Kerja : " + dwi._tanggalMasukKerja);
                Console.WriteLine("Gaji Pokok : " + dwi._gajiPokok);
                Console.WriteLine("Tunjangan Karyawan : " + dwi._tunjanganKaryawan + Environment.NewLine);

                Console.WriteLine("Nama : " + trio._nama);
                Console.WriteLine("Jabatan : " + trio._jabatan);
                Console.WriteLine("Tanggal Masuk Kerja : " + trio._tanggalMasukKerja);
                Console.WriteLine("Gaji Pokok : " + trio._gajiPokok);
                Console.WriteLine("Tunjangan Karyawan : " + trio._tunjanganKaryawan + Environment.NewLine);
                Console.ReadLine();
            }
            else {
                Console.WriteLine ( "Input yang anda masukan salah");
                Console.ReadLine();   
                }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Praktik 1
            // Nama :  Seno Aji 
            // Kelas : X PPLG 2
            // Membuat project console
            Console.WriteLine("Hello, World"); //Perintah untuk menampilkan teks di console

            // Praktik 2
            // Nama : Seno Aji
            // Kelas : X PPLG 2
            // Perbedaan Write dan WriteLine
            Console.Write("Hello");
            Console.Write("Hai");
            Console.WriteLine("Hola");
            Console.WriteLine("Dunia");

            // Praktik 3
            // Nama : Seno Aji
            // Kelas : X PPLG 2
            // Membuat dan memanggil variabel
            string nama = "Seno Aji";
            int umur = 15;
            double tinggi = 170;
            char kelas = 'X';
            bool aktif = true;
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Umur : " + umur + " tahun");
            Console.WriteLine("Tinggi : " + tinggi + " cm");
            Console.WriteLine("Kelas : " + kelas);
            Console.WriteLine("Aktif : " + aktif);
            Console.WriteLine();

            // Praktik 4
            // Nama : Seno Aji
            // Kelas : X PPLG 2
            // Input dan nama variabel
            Console.Write("Masukkan nama Anda: ");
            string nama0 = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Masukkan umur : ");
            int umur0 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("====== DATA SISWA ======");
            Console.WriteLine();
            Console.WriteLine("Nama : " + nama0);
            Console.WriteLine("Umur : " + umur0 + " tahun");
            Thread.Sleep(2000);

            // Praktik 5
            // Nama : Seno Aji
            // Kelas : X PPLG 2
            // Program biodata sederhana
            Console.Write("Nama Lengkap : ");
            string nama1 = Console.ReadLine();
            Console.Write("Absen : ");
            int absen = int.Parse(Console.ReadLine());
            Console.Write("Kelas (X, XI, atau XII) :");
            string kelas0 = Console.ReadLine();
            Console.Write("Jurusan : ");
            string jurusan = Console.ReadLine();
            Console.Write("Kelas ke : ");
            int kelasKe = int.Parse(Console.ReadLine());
            Console.Write("Sekolah : ");
            string sekolah = Console.ReadLine();

            Console.WriteLine("Hello, World");
            Console.WriteLine("=== Identitas Siswa ===");
            Console.WriteLine("Nama : " + nama1);
            Console.WriteLine("Kelas : X PPLG 2");
            Console.WriteLine("Jurusan : PPLG");

        }
    }
}

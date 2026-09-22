using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendaftaranPenduduk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat variabel kosong
            string nama;
            int umur;

            Console.WriteLine("=== PEROGAM PENDAFTARAN PENDUDUK ===");
            Console.Write("Masukan nama: ");
            nama = Console.ReadLine();
            Console.Write("Masukan alamat: ");
            var alamat = Console.ReadLine();
            Console.Write("Masukan umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terima Kasih!");
            Console.WriteLine("Data Berikut");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur} tahun");
            Console.WriteLine("SUDAH DISIMPAN!");

        }
    }
}

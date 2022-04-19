using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4309
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Paijo = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan Jono = new Karyawan("190302124", "Jono", 2000000);

            Console.WriteLine("No Nik/Nama            Gaji Bulanan ");
            Console.WriteLine("------------------------------------");
            Console.Write("1. {0}", Paijo.NIK);
            Console.Write(" {0}",Paijo.Nama);
            Console.WriteLine("     {0}", Paijo.GajiBulanan);
            Console.Write("1. {0}", Jono.NIK);
            Console.Write(" {0}", Jono.Nama);
            Console.WriteLine("      {0}", Jono.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine("Asyiiiik kenaikan gaji 10%");
            Console.WriteLine();

            float Paijo10 = Paijo.GajiBulanan + (Paijo.GajiBulanan / 100 * 10);
            float Jono10 = Jono.GajiBulanan + (Jono.GajiBulanan / 100 * 10);
            Console.WriteLine("No Nik/Nama            Gaji Bulanan ");
            Console.WriteLine("------------------------------------");
            Console.Write("1. {0}", Paijo.NIK);
            Console.Write(" {0}", Paijo.Nama);
            Console.WriteLine("     {0}", Paijo10);
            Console.Write("1. {0}", Jono.NIK);
            Console.Write(" {0}", Jono.Nama);
            Console.WriteLine("      {0}", Jono10);
            Console.ReadKey();
        }
    }
}

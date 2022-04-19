using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4309
{
    class Karyawan
    {
        public string NIK { get; set; }
        public string Nama{ get; set; }
        public float GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, float gajibulanan)
        {
            NIK = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;

            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
        }

    }
}

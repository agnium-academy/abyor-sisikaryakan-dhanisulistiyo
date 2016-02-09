using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Karyawan
    {
        public String _nama;
        public String _jabatan;
        public DateTime _tanggalMasukKerja;
        public String _tugas;
        public String _pemberhentian;

        public Karyawan()
        {
        }

        public String nama
        {
            get { return _nama; }
            set { _nama = nama; }
        }

        public String jabatan
        {
            get { return _jabatan; }
            set { _jabatan = jabatan; }
        }

        public DateTime tanggalMasukKerja
        {
            get { return _tanggalMasukKerja; }
            set { _tanggalMasukKerja = tanggalMasukKerja; }
        }


        public String tugas
        {
            get { return _tugas; }
            set { _tugas = tugas; }
        }

        public String pemberhentian
        {
            get { return _pemberhentian; }
            set { _pemberhentian = pemberhentian; }
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Staff : Karyawan
    {
        public string _training;
        public int _gajiPokok;
        public int _tunjanganKaryawan;

        public Staff()
        {

        }

        public Staff(string jabatan)
        {
            this._jabatan = jabatan;
        }


    }
}

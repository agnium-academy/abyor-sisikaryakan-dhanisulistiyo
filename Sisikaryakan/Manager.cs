using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Manager : Supervisor
    {
        public int _tunjanganHariRaya;
        public int _tunjanganStudyBanding;
        public int _tunjanganKesehatan;

        public Manager()
        {

        }

        public Manager(string jabatan)
        {
            this._jabatan = jabatan;
        }



    }
}

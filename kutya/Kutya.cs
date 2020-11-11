using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutya
{
    class Kutya
    {
        private int id;
        private int fajta_id;
        private int nev_id;
        private int eletkor;
        private string vizsgalat;


        public Kutya (int i, int f, int n ,int e, string v)
        {
            id = i;
            fajta_id = f;
            nev_id = n;
            eletkor = e;
            vizsgalat = v;
        }
    }
}

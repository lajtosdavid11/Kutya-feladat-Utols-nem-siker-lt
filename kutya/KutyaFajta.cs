using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutya
{
    class KutyaFajta
    {
        private int id;
        private string nev;
        private string eredetiNev;

        public int ID { get { return id; } }
        public string Nev { get { return nev; } }
        public string EredetiNev { get { return eredetiNev; } }


        public KutyaFajta(int id, string nev, string eredetiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }


    }
}

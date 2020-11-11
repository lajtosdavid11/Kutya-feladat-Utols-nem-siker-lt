using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kutya
{
    class Program
    {
        static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        static List<KutyaFajta> kutyafajta = new List<KutyaFajta>();
        static List<Kutya> kutya = new List<Kutya>();

        static void KutyaNevekBeolvas()
        {
            StreamReader be = new StreamReader("KutyaNevek.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }

            be.Close();

        }

        static void KutyaFajtaBeolv()
        {
            StreamReader be = new StreamReader("KutyaFajtak.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');
                kutyafajta.Add(new KutyaFajta(int.Parse(adat[0]), adat[1], adat[2]));
                
            }

            be.Close();
        }

        static void kutyaBeolv()
        {
            StreamReader be = new StreamReader("KutyaFajtak.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');
                kutya.Add(new Kutya(int.Parse(adat[0]), int.Parse(adat[1]), int.Parse(adat[2]),
                    int.Parse(adat[3]), adat[4]));

            }

            be.Close();
        }

        static void harmas()
        {
            Console.WriteLine($"Kutyanevek száma: {kutyaNevek.Count()}");
        }
        static void Main(string[] args)
        {

            KutyaNevekBeolvas();
            KutyaFajtaBeolv();
            kutyaBeolv();
            harmas();

            foreach (var t in kutya)
            {
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

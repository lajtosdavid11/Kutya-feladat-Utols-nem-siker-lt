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
            StreamReader be = new StreamReader("Kutyak.csv");

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

        static void hatodik()
        {
            double osszeg = 0;
            foreach (var t in kutya)
            {
                osszeg += t.Eletkor;
            }
            Console.WriteLine("Kutyak átlag életkora: " + osszeg/kutya.Count);

        }

        static void hetes()
        {
            
            int max = 0;
            int fajta = 0;
            int nev = 0;
            for (int i = 0; i < kutya.Count; i++)
            {
                if (kutya[i].Eletkor > max)
                {
                    max = kutya[i].Eletkor;
                    fajta = kutya[i].Fajtaid;
                    nev = kutya[i].Nevid;
                }

            }
            
            int j = 0;
            string fajtaa = "";
            
            while (j < kutyafajta.Count)
            {
                if (kutyafajta[j].ID == fajta)
                {
                    fajtaa = kutyafajta[j].Nev;
                    
                }
                j++;
            }

            string neve = "";
            j = 0;
            while (j < kutyaNevek.Count)
            {
                if (kutyaNevek[j].Id == nev)
                {
                    neve = kutyaNevek[j].Nev;
                }
                j++;
            }
            Console.WriteLine($"A legidősebb kutya neve és fajtája: {neve}, {fajtaa}");





        }

        static void nyolcas()
        {
            Dictionary<string, int> jantiz = new Dictionary<string, int>();
            for (int i = 0; i < kutya.Count; i++)
            {
                if (kutya[i].Vizsgalat == "2018.01.10")
                {
                    for (int j = 0; j < kutyafajta.Count; j++)
                    {
                        if (kutyafajta[j].ID == kutya[i].Fajtaid)
                        {
                            jantiz.Add(kutyafajta[j].Nev, 1);
                        }
                    }
                }
            }
            Console.WriteLine("Január 10.-én vizsgált kutya fajták: ");
            foreach (var t in jantiz)
            {
                
                Console.WriteLine($"\t {t.Key} : {t.Value}");
                
            }

            
            
         
        }

        static void kilences()
        {
            Dictionary<string, int> leterhelt = new Dictionary<string, int>();
            foreach (var t in kutya)
            {
                if (!leterhelt.ContainsKey(t.Vizsgalat))
                {
                    leterhelt.Add(t.Vizsgalat, 0);
                }
            }
            foreach (var t in kutya)
            {
                leterhelt[t.Vizsgalat]++;
            }
            int max = leterhelt.Values.First();
            string maxx = leterhelt.Keys.First();

            foreach (var t in leterhelt)
            {
                if (max < t.Value)
                {
                    max = t.Value;
                    maxx = t.Key;
                }
            }
            Console.WriteLine($"Legjobban leterhelt nap: {maxx} : {max} kutya");

        }

        static void tizes()
        {
            //StreamWriter sw = new StreamWriter("nevstatisztika.txt");
            //Dictionary<string, int> statisztika = new Dictionary<string, int>();
            //foreach (var t in kutyaNevek)
            //{
            //    if (!statisztika.ContainsKey(t.Id.ToString()))
            //    {
            //        statisztika.Add(t.Id.ToString(), 0);
            //    }
            //}
            //foreach (var t in kutya)
            //{
            //    statisztika[t.Nevid.ToString()]++;
            //}
            //int osszeg = 0;
            //foreach (var t in kutyafajta)
            //{

            //}

        }

        
        static void Main(string[] args)
        {

            KutyaNevekBeolvas();
            KutyaFajtaBeolv();
            kutyaBeolv();
            harmas();
            hatodik();
            hetes();
            nyolcas();
            kilences();
            tizes();

            

            Console.ReadKey();

        }
    }
}

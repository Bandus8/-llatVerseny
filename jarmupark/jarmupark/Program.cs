using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jarmupark
{
    abstract class Jarmu
    { 
    public string Azonosito { get;private set; }
    public string Rendszam { get;private set; }
    public int gyartasiEv { get;private set; }
    public double fogyasztas { get;private set; }


    public double futottKm { get; private set; }
    public int AktualisKoltseg { get; private set; }
    public bool Szabad { get; private set; }


    public static int AktualisEv { get; set; }
    public static int alapDij { get; set; }
    public static double HaszonKulcs { get; set;}



        public Jarmu(string azonosito, string rendszam, int gyartasiEv, double fogyasztas) 
        {
            this.Azonosito = azonosito;
            this.Rendszam = rendszam;
            this.gyartasiEv = gyartasiEv;
            this.fogyasztas = fogyasztas;
            this.Szabad = true;
        }
        public Jarmu(string azonosito, string rendszam, int gyartasiEv)
        {
            this.Azonosito = azonosito;
            this.Rendszam = rendszam;
            this.gyartasiEv = gyartasiEv;
            this.Szabad = true;
        }

        public int Kor()
        {
            return AktualisEv - gyartasiEv;
        }

        public bool Fuvaroz(double ut, int benzinAr)
        {
            if (Szabad)
            {
                futottKm += ut;
                AktualisKoltseg = (int)(benzinAr * ut * fogyasztas / 100);
                Szabad = false;
                return true;
            }
            return false;
        }

        public virtual int BerletiDij() 
        {
            return (int)(alapDij + AktualisKoltseg + AktualisKoltseg * HaszonKulcs / 100);
        }

        public void Vegzett()
        {
            Szabad = true;
        }

        public override string ToString()
        {
            return "\nA" + this.GetType().Name.ToLower() + " azonosítója: " + Azonosito
            + "\nrendszáma: " + Rendszam  + "\n kora: " + Kor() + " év" + "\n fogyasztása: "
            + fogyasztas + " l/100km" + "\n km óra állása: " + futottKm + " km";
        }



    }
    class Busz : Jarmu
    {
        public int Ferohely { get; private set; }
        public static double Szorzo { get; set; }

        public Busz(string azonosito, string rendszam, int gyartasiEv,
            double fogyasztas, int ferohely) :
            base(azonosito, rendszam, gyartasiEv, fogyasztas)
        {
            this.Ferohely = ferohely;
        }
        public Busz(string azonosito, string rendszam, int gyartasiEv, int ferohely) :
        base(azonosito, rendszam, gyartasiEv)
        {

            this.Ferohely = ferohely;
        }

        public override int BerletiDij()
        {
            return (int)(base.BerletiDij() + Ferohely * Szorzo);

        }
        public override string ToString()
        {
            return base.ToString() +
                "\n\tférőhelyek száma: " + Ferohely;
        }



    }
    class TeherAuto : Jarmu
    { 
    public double TeherBiras { get; private set; }
    public static double szorzo { get; set; }

        public TeherAuto(string azonosito, string rendszam, int gyartasiEv,
                double fogyasztas, double teherbiras) :
                base(azonosito, rendszam, gyartasiEv, fogyasztas)
        {
            this.TeherBiras = teherbiras;
        }
        public TeherAuto(string azonosito, string rendszam, int gyartasiEv, double teherbiras) :
        base(azonosito, rendszam, gyartasiEv)
        {

            this.TeherBiras = teherbiras;
        }
        public override int BerletiDij()
        {
            return (int)(base.BerletiDij() + TeherBiras * szorzo);

        }
        public override string ToString()
        {
            return base.ToString() +
                "\n\tteherbírás: " + TeherBiras + "tonna";
        }



    }

    class Vezerles 
    { 
    private List<Jarmu> jarmuvek = new List<Jarmu> ();
        private string BUSZ = "busz";
        private string TEHERAUTO = "teherautó";

        public void Indit()
        {
            Beallit();
            AdatBevitel();
            Kiiratas("\nA regisztrált járművek: ");
            Mukodtet();
            Kiiratas("\nA működés utáni állapot: ");
            AtlagKor();
            LegtobbKilometer();
            Rendez();
        }
        private void Beallit()
        {
            Jarmu.AktualisEv = 2024;
            Jarmu.alapDij = 1000;
            Jarmu.HaszonKulcs = 10;

            Busz.Szorzo = 15;
            TeherAuto.szorzo = 8.5;
        }
        private void AdatBevitel()
        {
            string rendszam, azonosito;
            int gyartEv, ferohely;
            double fogyasztas, teherbiras;

            StreamReader sr = new StreamReader("jarmuvek.txt");

            int sorszam = 1;

            while (!sr.EndOfStream)
            {
                string sor;
                string[] s;
                sor = sr.ReadLine();
                s = sor.Split(';');
                rendszam = s[1];
                gyartEv = int.Parse(s[2]);
                fogyasztas = double.Parse(s[3]);
                azonosito = s[0];

                if (azonosito == "busz")
                {
                    azonosito = Convert.ToString(sorszam);
                    ferohely = int.Parse(s[4]);
                    jarmuvek.Add(new Busz(azonosito, rendszam, gyartEv, fogyasztas, ferohely));
                }
                else if (azonosito == "teherautó")
                {
                    azonosito = Convert.ToString(sorszam);
                    teherbiras = double.Parse(s[4]);
                    jarmuvek.Add(new TeherAuto(azonosito, rendszam, gyartEv, fogyasztas, teherbiras));
                }
                sorszam++;
            }
            sr.Close();

        }
        private void Kiiratas(string sor)
        {
            Console.WriteLine(sor);
            foreach (Jarmu jarmu in jarmuvek)
            {
                Console.WriteLine(jarmu);
            }
        }

        private void Mukodtet()
        {
            int osszkoltseg = 0, osszBevetel = 0;

            Random rnd = new Random();
            int alsobenzin = 600, felsobenzin = 650;
            double utmax = 300;
            int mukodeshatar = 200;
            int jarmui;

            Jarmu jarmu;
            int fuvarszam = 0;

            for (int i = 0; i < (int)rnd.Next(mukodeshatar); i++)
            {
                jarmui = rnd.Next(jarmuvek.Count);
                jarmu = jarmuvek[jarmui];
                if (jarmu.Fuvaroz(rnd.NextDouble() * utmax, rnd.Next(alsobenzin, felsobenzin)))
                {
                    fuvarszam++;
                    Console.WriteLine("\nAz induló jármű rendszáma: " + jarmu.Rendszam
                        + "\nAz aktuális fuvarozási költség: " + jarmu.AktualisKoltseg + " Ft."
                        + "\nAz aktuális bevétel: " + jarmu.BerletiDij() + " Ft.");
                }
                osszBevetel += jarmu.BerletiDij();
                osszkoltseg += jarmu.AktualisKoltseg;


            }
            Console.WriteLine("\nA cég teljes költsége: " + osszkoltseg + " Ft."
                + "\nA teljes bevétele: "+ osszBevetel + " Ft." + "\nHaszna" + (osszBevetel - osszkoltseg)
                + " Ft.");
            Console.WriteLine("\nA fuvarok száma: " + fuvarszam);


        }

        private void AtlagKor()
        {
            double oszkor = 0;
            int db = 0;
            foreach (Jarmu i in jarmuvek)
            {
                oszkor += i.Kor();
                db++;
            }
            if (db > 0)
            {
                Console.WriteLine( "\nA járművek átlag kora: " + oszkor / db + " év.");
            }
            else
            {
                Console.WriteLine("Nincsenek járművek.");
            }
        }
        private void LegtobbKilometer() 
        {
            double max = jarmuvek[0].futottKm;
            foreach (Jarmu item in jarmuvek)
            {
                if (item.futottKm > max)
                {
                    max = item.futottKm;
                }
            }
            Console.WriteLine("\nA legtöbbet futott jármű(vek) {0: 000.00} km-rel",max);
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu.futottKm == max)
                {
                    Console.WriteLine( jarmu.Rendszam);
                }
            }


        }
        
        
        
        private void Rendez()
        {
            Jarmu temp;

            for (int i = 0; i < jarmuvek.Count-1; i++)
            {
                for (int j = 0; j < jarmuvek.Count; j++)
                {
                    if (jarmuvek[i].fogyasztas > jarmuvek[j].fogyasztas)
                    {
                        temp = jarmuvek[i];
                        jarmuvek[i] = jarmuvek[j];
                        jarmuvek[i] = temp;
                    }
                }
            }
            Console.WriteLine( "\nA járművek fogyasztás szerint rendezve: ");
            foreach (Jarmu i in jarmuvek)
            {
                Console.WriteLine("{0,-10} {1:00.0} liter / 100 km", i.Rendszam,i.fogyasztas);
            }
        }



    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vezerles vezerles = new Vezerles();
            vezerles.Indit();
            Console.ReadKey();

        }
    }
}

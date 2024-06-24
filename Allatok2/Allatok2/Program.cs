using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatok2
{
    class Versenyzo
    {

        private string nev;
        private int szuletesEv;

        private int szepseg, viselkedes;
        private int pont;

        private static int Ev;
        private static int korHatar;

        private int rajtSzam;
        private int oltasiSzam;




        public Versenyzo(string nev, int szuletesEv, int rajtSzam, int oltasiSzam)
        {
            this.nev = nev;
            this.szuletesEv = szuletesEv;
            this.rajtSzam = rajtSzam;
            this.oltasiSzam = oltasiSzam;

        }

        public int Kor()
        {
            return Ev - szuletesEv;
        }
        public void Pontozas(int szepseg, int viskelkedes)
        {
            this.szepseg = szepseg;
            this.viselkedes = viskelkedes;
            
        }
        public int PontSzam()
        { if (Kor() <= korHatar) 
        {
                return viselkedes * Kor() + szepseg * (korHatar - Kor());
            }
            return 0;
        }
        public override string ToString()
        {
            return nev + " Pontszáma: " + PontSzam() + " Rajtszáma: " + rajtSzam;
        }

        public string Neve
        {
            get { return nev; }
        }

        public int SzuletesEve
        {
            get { return szuletesEv; }
        }

        public int SzepsegPontja
        {
            get { return szepseg; }
        }

        public int ViselkedesPontja
        {
            get { return viselkedes; }
        }

        public int Pontszama
        {
            get { return PontSzam(); }
        }
        

        public static int AktualisEv
        {
            get { return Ev; }
            set { Ev = value; }
        }

        public static int KorHatar
        {
            get { return korHatar; }
            set { korHatar = value; }
        }
         
        public static int rajtszama
        {
            get { return rajtszama; }
            set { rajtszama = value; }
        }

       public  static void AllatVerseny()
        {
            Versenyzo versenyzo;

            string nev;
            int szulEv;
            int igazolas;
            int szepseg, viselkedes;
            int veletlenPontHatar = 10;
            int rajtszam = 0;

            Random rand = new Random();

            int osszesVersenyzo = 0;
            int osszesPont = 0;
            int legtobbPont = 0;
            Console.WriteLine("Kezdődik a verseny");
            char tovabb = 'i';
            while (tovabb == 'i')
            {
                Console.Write("Az állat neve: ");
                nev = Console.ReadLine();
                Console.Write("születési éve: ");
                while (!int.TryParse(Console.ReadLine(), out szulEv)
                || szulEv <= 0
                || szulEv > Ev)
                {
                    Console.Write("Hibás adat, kérem újra.:");
                }
                Console.Write("Oltási igazolás száma: ");
                igazolas = int.Parse(Console.ReadLine());


                rajtszam++;

                szepseg = rand.Next(veletlenPontHatar + 1);
                viselkedes = rand.Next(veletlenPontHatar + 1);


                versenyzo = new Versenyzo(nev, szulEv, rajtszam, igazolas);

                versenyzo.Pontozas(szepseg, viselkedes);
                Console.WriteLine(versenyzo);

                osszesVersenyzo++;
                osszesPont += versenyzo.PontSzam();
                if (legtobbPont < versenyzo.Pontszama)
                {
                    legtobbPont = versenyzo.Pontszama;
                }
                Console.Write("Van még állat? (i/n) ");

                tovabb = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nÖsszesen " + osszesVersenyzo + " versenyző volt," +
                " \nösszpontszámuk: " + osszesPont + " pont," + "\nlegnagyobb pontszám: " + legtobbPont + "\nÁtlag pontszám: " + osszesPont / osszesVersenyzo);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int aktualisEv = 2024;
            int korhatar = 10;

            Versenyzo.AktualisEv = aktualisEv;
            Versenyzo.KorHatar = korhatar;

            Versenyzo.AllatVerseny();

            Console.ReadKey();
        }
    }
}

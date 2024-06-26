using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace listák
{
   public  class Versenyzo
    {
        private int rajtSzam;
        private string nev;
        private string szak;
        private int pontSzam;

        public Versenyzo(int rajtSzam, string nev, string szak)
        { 
        this.rajtSzam = rajtSzam;
            this.nev = nev;
            this.szak = szak;   
        }


        public void PontotKap(int pont)
        {
            pontSzam += pont;
        }

        public override string ToString()
        {
            return $"|{rajtSzam, -10}|{nev, -20}|{szak, -20}|{pontSzam + 5}   pont|";

        }

        public int RajtSzam => rajtSzam;
            
        public string Nev => nev;
        
        public string Szak => szak;
        
        public int PontSzam => pontSzam;

       

    }

    public class VezerloOsztaly 
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo> ();

        public void Start()
        {
            AdatBevitel();

            Kiiratas("\nRésztvevők:\n");
            Verseny();
            Kiiratas("\nEredmények:\n");

            Nyertes();
            Sorrend();
            int szam;
            Keresesek();

        }
        private void AdatBevitel()
        {
            Versenyzo versenyzo;

            

            string nev;
            string szak;
            int sorszam = 1;

            StreamReader sr = new StreamReader("versenyzok.txt");

            while (!sr.EndOfStream) 
            {
                string sor;
                string[] s;
                sor = sr.ReadLine();
                s = sor.Split(';');
                nev = s[0];
                szak = s[1];
                versenyzo = new Versenyzo(sorszam, nev, szak);
                versenyzok.Add(versenyzo);
                sorszam++;
            }
        }
        private void Kiiratas(string sor) 
        {
            Console.WriteLine(sor);
            foreach (Versenyzo db in versenyzok)
            {
                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                Console.WriteLine(db);
            }
            Console.WriteLine("+----------+--------------------+--------------------+---------+");
        }
        private int zsuriletszam = 5;
        private int pontHatar = 10;
        private void Verseny() 
        { 
        Random rnd = new Random();
            int pontok;
            foreach (Versenyzo alany in versenyzok)
            {
                for (int i = 0; i < zsuriletszam; i++)
                {
                    pontok = rnd.Next(pontHatar);
                    alany.PontotKap(pontok);
                }
            }
        }
        private void Nyertes()
        {
            int max = versenyzok[0].PontSzam;

            foreach (Versenyzo alany in versenyzok)
            {
                if (alany.PontSzam > max)
                {
                    max = alany.PontSzam;
                }
            }

            Console.WriteLine("\nA legjobb(ak)\n");
            foreach (Versenyzo alany in versenyzok)
            {
                if (alany.PontSzam == max)
                {

                    Console.WriteLine(alany);
                }
            }


        }

        private void Sorrend()
        {
            Versenyzo ideiglenes;
            for (int i = 0; i < versenyzok.Count - 1; i++)
            {
                for (int j = 0; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].PontSzam < versenyzok[j].PontSzam)
                    {
                        ideiglenes = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = ideiglenes;
                    }
                }
            }
            Kiiratas("\nEredménytábla\n");

        }
        private void Keresesek()
        {
        
            Console.WriteLine("Milyen szempont alapján akar keresni?" +
                "\n1: Adott szak szerint?" +
                "\n2: Név szerint?" +
                "\n3: Pont szerint?"+
                "\n4: Abbahagyom a keresést!"
                );
            int szam;
            while (!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Egy számot írjon. ");
            }
            while (szam < 4 && szam > 0)
            {


                if (szam == 1)
                {
                    Console.WriteLine("\nAdott szakhoz tartotó versenyzők keresése\n");
                    Console.WriteLine("\nKeres valakit (i/n) ");
                    char valasz;
                    while (!char.TryParse(Console.ReadLine(), out valasz))
                    {
                        Console.WriteLine("Egy karaktert írjon. ");
                    }
                    string szak;
                    bool vane = false;

                    while (valasz == 'i' || valasz == 'I')
                    {
                        Console.WriteLine("Szak: ");
                        szak = Console.ReadLine();
                        vane = false;

                        foreach (Versenyzo alany in versenyzok)
                        {
                            if (alany.Szak == szak)
                            {
                                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                                Console.WriteLine(alany.ToString());
                                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                                vane = true;
                            }
                           
                        }


                        if (vane == false)
                        {
                            Console.WriteLine("Erről a szakról nem indult senki!");
                        }
                        Console.WriteLine("Keres mást? (i/n) ");
                        while (!char.TryParse(Console.ReadLine(), out valasz))
                        {
                            Console.WriteLine("Egy karaktert írjon. ");
                        }
                        if (valasz == 'n' || valasz == 'N')
                        {
                            Console.WriteLine("Milyen szempont alapján akar keresni?" +
                     "\n1: Adott szak szerint?" +
                     "\n2: Név szerint?" +
                     "\n3: Pont szerint?" +
                     "\n4: Abbahagyom a keresést!"
                     );

                            while (!int.TryParse(Console.ReadLine(), out szam))
                            {
                                Console.WriteLine("Egy számot írjon. ");
                            }
                        }

                    }
                }
                else if (szam == 2)
                {
                    Console.WriteLine("\nNév szerinti versenyző keresése\n");
                    Console.WriteLine("\nKeres valakit (i/n) ");
                    char valasz;
                    while (!char.TryParse(Console.ReadLine(), out valasz))
                    {
                        Console.WriteLine("Egy karaktert írjon. ");
                    }
                    string neve;
                    bool vane;

                    while (valasz == 'i' || valasz == 'I')
                    {
                        Console.WriteLine("Név: ");
                        neve = Console.ReadLine();
                        vane = false;

                        foreach (Versenyzo alany in versenyzok)
                        {
                            if (alany.Nev.ToLower() == neve.ToLower())
                            {
                                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                                Console.WriteLine(alany);
                                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                                vane = true;
                            }
                            
                        }

                        if (!vane)
                        {
                            Console.WriteLine("Ezzel a névvel nem indult senki!");
                        }
                        Console.WriteLine("Keres mást? (i/n) ");
                        while (!char.TryParse(Console.ReadLine(), out valasz))
                        {
                            Console.WriteLine("Egy karaktert írjon. ");
                        }
                        if (valasz == 'n' || valasz == 'N')
                        {
                            Console.WriteLine("Milyen szempont alapján akar keresni?" +
                     "\n1: Adott szak szerint?" +
                     "\n2: Név szerint?" +
                     "\n3: Pont szerint?" +
                     "\n4: Abbahagyom a keresést!"
                     );

                            while (!int.TryParse(Console.ReadLine(), out szam))
                            {
                                Console.WriteLine("Egy számot írjon. ");
                            }
                        }
                    }
                }
                else if (szam == 3)
                {

                    Console.WriteLine("\nAdott pont feletti versenyzők keresése\n");
                    Console.WriteLine("\nKeres valakit (i/n) ");
                    char valasz;
                    while (!char.TryParse(Console.ReadLine(), out valasz))
                    {
                        Console.WriteLine("Egy karaktert írjon. ");
                    }
                    int pontja;
                    bool vane;

                    while (valasz == 'i' || valasz == 'I')
                    {
                        Console.WriteLine("Pont: ");
                        pontja = int.Parse(Console.ReadLine());
                        vane = false;

                        foreach (Versenyzo alany in versenyzok)
                        {
                            if (alany.PontSzam >= pontja)
                            {
                                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                                Console.WriteLine(alany);
                                Console.WriteLine("+----------+--------------------+--------------------+---------+");
                                vane = true;

                            }
                           
                        }

                        if (!vane)
                        {
                            Console.WriteLine("Ennyi pontot nem szerzett senki senki!");
                        }

                        Console.WriteLine("Keres más pontszám szerint? (i/n) ");
                        while (!char.TryParse(Console.ReadLine(), out valasz))
                        {
                            Console.WriteLine("Egy karaktert írjon. ");
                        }
                    }
                    if (valasz == 'n' || valasz == 'N')
                    {
                        Console.WriteLine("Milyen szempont alapján akar keresni?" +
                        "\n1: Adott szak szerint?" +
                        "\n2: Név szerint?" +
                        "\n3: Pont szerint?" +
                        "\n4: Abbahagyom a keresést!"
                         );
                        while (!int.TryParse(Console.ReadLine(), out szam))
                        {
                            Console.WriteLine("Egy számot írjon. ");
                        }
                    }


                }
                else if (szam == 4)
                {
                    Console.WriteLine("Keresés abbahagyva.");
                }
                else
                {
                    Console.WriteLine("\n A négy szám közül válasszon!\n");
                }
            }
            if (szam == 4)
            {
                Console.WriteLine("Keresés abbahagyva. ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VezerloOsztaly vezerles = new VezerloOsztaly();
            vezerles.Start();

            

            Console.ReadKey();



        }
    }
}

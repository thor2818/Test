using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct PersonStruct
        {
            public string Navn;
            public int Foedselsar;
            public int Hoejde;
            public bool Kvinde;
        }

        const int AntalElever = 6;
        static PersonStruct[] Klasse9A = new PersonStruct[AntalElever];

        static void Klasse9AUdskriv()
        {
            int i;
            for (i = 0; i < AntalElever; i++)
            {
                // Debug.Print Klasse9A(i).Navn & " " & Klasse9A(i).Foedselsar & " " & Year(Now()) - Klasse9A(i).Foedselsar
                Console.WriteLine(Klasse9A[i].Navn + " " + Klasse9A[i].Foedselsar + " " + (DateTime.Now.Year - Klasse9A[i].Foedselsar));
            }
        }

        // Function MaksimumAlderAfKlasse9A() As Double
        static Double MaksimumAlderAfKlasse9A()
        {
            int i;
            int Resultat;
            int NaesteAlder;

            Resultat = 0;
            // For i = 0 To AntalElever - 1
            for (i = 0; i < AntalElever; i++)
            {
                NaesteAlder = DateTime.Now.Year - Klasse9A[i].Foedselsar;
                if (NaesteAlder > Resultat)
                {
                    Resultat = NaesteAlder;
                }
            }
            return Resultat;
        }

        static Double MinimumAlderAfKlasse9A()
        {
            int i;
            int Resultat;
            int NaesteAlder;

            Resultat = 999;
            // For i = 0 To AntalElever - 1
            for (i = 0; i < AntalElever; i++)
            {
                NaesteAlder = DateTime.Now.Year - Klasse9A[i].Foedselsar;
                if (NaesteAlder < Resultat)
                {
                    Resultat = NaesteAlder;
                }
            }
            return Resultat;
        }

        static Double GennemsnitAlderAfKlasse9A()
        {
            int i;
            double Resultat;

            Resultat = 0;
            // For i = 0 To AntalElever - 1
            for (i = 0; i < AntalElever; i++)
            {
                Resultat = Resultat + DateTime.Now.Year - Klasse9A[i].Foedselsar;
            }
            return Resultat / AntalElever;
        }

        static void AldersforskelAfTo(int FørstesIndexNummer, int AndensIndexNummer)
        {
            int AldersForskel;
            AldersForskel = Klasse9A[FørstesIndexNummer].Foedselsar - Klasse9A[AndensIndexNummer].Foedselsar;
            Console.WriteLine("Aldersforskellen mellem " + Klasse9A[FørstesIndexNummer].Navn + " og " + Klasse9A[AndensIndexNummer].Navn + " er " + AldersForskel + " år");
        }

        static void Main(string[] args)
        {
            string s;

            Klasse9A[0].Navn = "Thorbjørn";
            Klasse9A[0].Foedselsar = 2002;
            Klasse9A[1].Navn = "Theo";
            Klasse9A[1].Foedselsar = 2001;
            Klasse9A[2].Navn = "Frederik";
            Klasse9A[2].Foedselsar = 2002;
            Klasse9A[3].Navn = "Peter";
            Klasse9A[3].Foedselsar = 2002;
            Klasse9A[4].Navn = "Kasper";
            Klasse9A[4].Foedselsar = 2001;
            Klasse9A[5].Navn = "Far";
            Klasse9A[5].Foedselsar = 1965;

            Console.WriteLine(Klasse9A[0].Navn);
            Klasse9AUdskriv();
            Console.WriteLine(MaksimumAlderAfKlasse9A());
            Console.WriteLine(MinimumAlderAfKlasse9A());
            Console.WriteLine(GennemsnitAlderAfKlasse9A());
            AldersforskelAfTo(0, 1);
            AldersforskelAfTo(0, 2);

            s = Console.ReadLine();
        }
    }
}
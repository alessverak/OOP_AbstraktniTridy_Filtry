
namespace OOP_krokPoKroku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DopravniProstredek> prostredky = new List<DopravniProstredek>();
            prostredky.Add(new Auto("Škoda", 180, 5));
            prostredky.Add(new Kolo("Author", 35, "hliník"));
            prostredky.Add(new Lod("Katamaran", 18, "plachty"));

            //Výpis všech
            foreach (var dopravniProstredek in prostredky)
            {
                dopravniProstredek.Popis();
            }

            //Výpis pouze auta
            Console.WriteLine("---- Pouze auta. ---");
            foreach (var dopravniProstredek in prostredky)
            {
                if (dopravniProstredek is Auto auto)
                {
                    auto.Popis();
                }
            }
            Console.WriteLine();

            //Výpis pouze lodě
            Console.WriteLine("---- Pouze lodě. ----");
            foreach (var dopravniProstredek in prostredky)
            {
                if (dopravniProstredek is Lod lod)
                {
                    lod.Popis();
                }
            }
            Console.WriteLine();

            //Výpis pouze kola
            Console.WriteLine("---- Pouze kola. ----");
            foreach (var dopravniProstredek in prostredky)
            {
                if (dopravniProstredek is Kolo kolo)
                {
                    kolo.Popis();
                }
            }
            Console.WriteLine();
            }

            

        }
        public abstract class DopravniProstredek
        {
            public string Jmeno { get; }
            public int MaximalniRychlost { get; }

            public DopravniProstredek(string jmeno, int maximalniRychlost)
            {
                Jmeno = jmeno;
                MaximalniRychlost = maximalniRychlost;
            }
            // Abstraktní metoda - povinná pro všechny potomky!
            public abstract void Popis();

        }
        public class Auto : DopravniProstredek
        {
            public int PocetDveri { get; set; }
            public Auto(string jmeno, int maximalniRychlost, int pocetDveri) : base(jmeno, maximalniRychlost)
            {
                PocetDveri = pocetDveri;
            }
            public override void Popis()
            {
                Console.WriteLine($"Auto {Jmeno} jede maximálně {MaximalniRychlost} km/h a má {PocetDveri} dveří.");
            }
        }
        public class Kolo : DopravniProstredek
        {
            public string TypRamu { get; set; }

            public Kolo(string jmeno, int maximalniRychlost, string typRamu) : base(jmeno, maximalniRychlost)
            {
                TypRamu = typRamu;
            }

            public override void Popis()
            {
                Console.WriteLine($"Kolo {Jmeno} jede maximálně {MaximalniRychlost} km/h a má rám typu {TypRamu}.");
            }
        }
        public class Lod : DopravniProstredek
        {
            public string TypPohonu { get; set; }

            public Lod(string jmeno, int maximalniRychlost, string typPohonu) : base(jmeno, maximalniRychlost)
            {
                TypPohonu = typPohonu;
            }


            public override void Popis()
            {
                Console.WriteLine($"Loď {Jmeno} pluje maximálně {MaximalniRychlost} km/h a má pohon {TypPohonu}. ");
            }
        }

    }


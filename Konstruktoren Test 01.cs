using System;

namespace KonstruktorenTest
{
    
    class Program
    {
        static void Main()
        {
            Computer PC1 = new Computer("AMD Ryzen 5", "3.6GHz","27Zoll" );
            Computer PC2 = new Computer(20);
            Computer PC3 = new Computer(50, "0,9GHz");
            Console.WriteLine(PC1.fabrikat);
            Console.WriteLine(PC3.leistung + " " + PC3.preis);
            //Console.WriteLine(PC3.preis);
            Console.WriteLine("Ist der PC schon älter?" + " " + PC1.IstSchonÄlter());
            Console.WriteLine("Ist der PC schon älter?" + " " + PC2.IstSchonÄlter());

        }
    }

    class Computer
    {
        public string fabrikat;
        public int preis;
        public string leistung;
        public string bildschirmgröße;
        public int alter;

        public bool IstSchonÄlter()
        {
            if (alter >= 20)
            {
                return true;
                
            }
            return false;

        }

        public Computer()
        {
        }

        public Computer(int aAlter)
        {
            alter = aAlter;
        }

        public Computer(int aPreis, string aLeistung)
        {
            preis = aPreis;
            leistung = aLeistung;
        }

        public Computer(string aFabrikat, string aLeistung, string aBildschirmgröße)
        {
            fabrikat = aFabrikat;
            leistung = aLeistung;
            bildschirmgröße = aBildschirmgröße;
        }
    }
}





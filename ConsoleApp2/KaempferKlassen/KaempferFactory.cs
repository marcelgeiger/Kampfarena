using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.KaempferKlassen
{
    class KaempferFactory
    {
        public Kämpfer SpielerErstellen(int hp, int atk, int speed, int def, string name, int klassenTyp)
        {

            Kämpfer kaempfer;

            switch (klassenTyp)
            {
                case 1:
                    return kaempfer = new Berserker(hp, atk, speed, def, name);
                case 2:
                    return kaempfer = new Magier(hp, atk, speed, def, name);
                case 3:
                    return kaempfer = new Schurke(hp, atk, speed, def, name);
                case 4:
                    return kaempfer = new Tank(hp, atk, speed, def, name);
                default:
                    Console.WriteLine("falsche eingabe");
                    return null;
            }
        }


        Kämpfer Schwierigkeitsgrad(int lvl)
        {
            int punktePool = lvl * 10;

            Random rnd = new Random();


            int hp = rnd.Next(0, punktePool);
            punktePool -= hp;
            int atk = rnd.Next(0, punktePool);
            punktePool -= atk;
            int speed = rnd.Next(0, punktePool);
            punktePool -= speed;
            int def = rnd.Next(0, punktePool);
            punktePool -= def;

            string name = "CP";
            int klassenTyp = rnd.Next(1, 4);

            return SpielerErstellen(hp, atk, speed, def, name, klassenTyp);
        }

        // von 1-5
        // 1 = 50 punkte vergabe
        // 2 = 60
        // 3 = 70
        // 4 = 80
        // 5 = 90

        // 5 gegner
        private List<Kämpfer> ComputerGegnerErstellen(int schwierigkeit, int gegneranzahl)
        {
            List<Kämpfer> gegnerListe = new List<Kämpfer>();

            for (int i = 0; i < gegneranzahl; i++)
            {
                gegnerListe.Add(Schwierigkeitsgrad(schwierigkeit));

            }
            return gegnerListe;
        }

    }
}

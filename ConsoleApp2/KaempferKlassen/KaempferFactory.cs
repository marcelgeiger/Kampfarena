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


        Kämpfer Schwierigkeitsgrad(int dif)
        {
            int p = (dif * 20) / 4;

            Random rnd = new Random();

            int klassenTyp = rnd.Next(1, 4);
            string name = "";

            switch (klassenTyp)
            {
                case 1: name = "Berserker";
                    break;
                case 2: name = "Magier";
                    break;
                case 3: name = "Schurke";
                    break;
                case 4: name = "Tank";
                    break;
                default:
                    break;
            }

            return SpielerErstellen(p, p, p, p, name, klassenTyp);
        }

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

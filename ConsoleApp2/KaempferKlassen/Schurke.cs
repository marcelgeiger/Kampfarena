using System;

namespace ConsoleApp2
{
    class Schurke : Kämpfer
    {
        // 50% mehr Speed
        //double schaden;


        public Schurke(int leben, int atk, int speed, int def, string name)
        {
            this.Leben = (leben * 1);
            this.Angriffskraft = (atk * 1);
            this.Verteidigungskraft = (def * 0.8);
            this.Geschwindigkeit = (speed * 1.5);
            this.Name = name;
        }

        public override bool KannFähigkeitBenutzen()
        {
            // Chance auf doppelten Angriff
            // 40%
            Random rnd = new Random();
            if (rnd.Next(0, 9) < 4)
            {
                return true;
            }

            return false;
        }

        public override void Klassenfähigkeit(Kämpfer gegner)
        {
           KritischerAngriff(gegner);
        }

        void KritischerAngriff(Kämpfer gegner)
        {
            double schaden = 2 * (this.Angriffskraft * (1 - (gegner.Verteidigungskraft / 100)));
            gegner.Leben = gegner.Leben - schaden;
            Console.WriteLine("{0} macht {1} schaden ", gegner.Name, schaden);
            Console.WriteLine("{0} hat {1} HP", gegner.Name, gegner.Leben);
        }
    }
}
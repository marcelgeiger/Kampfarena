using System;

namespace ConsoleApp2
{
    class Magier : Kämpfer
    {
        
        public Magier(int leben, int atk, int speed, int def, string name)
        {
            this.Leben = (leben * 0.9);
            this.Angriffskraft = (atk * 0.4);
            this.Verteidigungskraft = (def * 0.7);
            this.Geschwindigkeit = (speed * 0.9);
            this.Name = name;
        }
        public override bool KannFähigkeitBenutzen()
        {
            // 60 Chance 40% leben
            Random rnd = new Random();
            if (rnd.Next(0, 9) < 6)
            {
                return true;
            }

            return false;
        }


        public override void Klassenfähigkeit(Kämpfer gegner)
        {
            if (gegner.Leben < this.Angriffskraft)
            {
                double schaden = (this.Angriffskraft * (1 - (gegner.Verteidigungskraft / 100)));
                gegner.Leben = -1;
                Console.WriteLine("Fähigkeit: Der Magier richtet seinen Gegner hin");
               Console.WriteLine("{0} hat {1} HP", gegner.Name, gegner.Leben);
                Console.WriteLine("_______________________________________________________________________________");

                return;
            }
            var leben = gegner.Leben;
            gegner.Leben = (gegner.Leben * 0.25);
            Console.WriteLine("Fähigkeit: Der Magier verwendet einen Zauber der seinem Gegner die Hälfte seines Leben nimmt!");
            Console.WriteLine("{0} Leben wurde von {1} auf {2} reduziert", gegner.Name, leben, gegner.Leben);
            Console.WriteLine("_______________________________________________________________________________");
        }
    }
}
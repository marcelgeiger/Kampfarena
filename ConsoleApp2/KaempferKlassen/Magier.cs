using System;

namespace ConsoleApp2
{
    class Magier : KaempferBase
    {
        
        public Magier(int leben, int atk, int speed, int def)
        {
            this.Leben = (leben * 0.9);
            this.Angriffskraft = (atk * 0.4);
            this.Verteidigungskraft = (def * 0.7);
            this.Geschwindigkeit = (speed * 0.9);
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


        public override void Klassenfähigkeit(KaempferBase gegner)
        {
            //feuer ball schießen

            gegner.Leben = (gegner.Leben * 0.5);
        }
    }
}
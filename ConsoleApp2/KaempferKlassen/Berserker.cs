using System;

namespace ConsoleApp2
{
    class Berserker : KaempferBase
    {
        // berserker bekommen 20% mehr auf stärke
        // 30% weniger rüstung
        // Rüstung kann ignoriert werden

        public Berserker(int leben, int atk, int speed, int def, string name)
        {
            this.Leben = (leben * 1);
            this.Angriffskraft = (atk * 1.3);
            this.Verteidigungskraft = (def * 0.8);
            this.Geschwindigkeit = (speed * 1);
            this.Name = name;
        }

        public override bool KannFähigkeitBenutzen()
        {
            // 30%
            Random rnd = new Random();
            if (rnd.Next(0, 9) < 3)
            {
                return true;
            }

            return false;
        }

        public override void Klassenfähigkeit(KaempferBase gegner)
        {
            gegner.Leben -= Angriffskraft;
        }
    }
}
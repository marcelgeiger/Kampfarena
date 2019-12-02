using System;

namespace ConsoleApp2
{
   public class Tank : Kämpfer
    {
        //Doppelt Leben
        //0.4 Angriff
        
        //kann Angriff blockieren

        public Tank(int leben, int atk, int speed, int def, string name)
        {
            this.Leben = (leben * 1.5);
            this.Angriffskraft = (atk * 0.4);
            this.Verteidigungskraft = (def * 1);
            this.Geschwindigkeit = (speed * 0.9);
            this.Name = name;
        }

        public int Block { get; set; }

        public override bool KannFähigkeitBenutzen()
        {
            //50 % auf Block
            Random rnd = new Random();
            if (rnd.Next(0, 9) < 5)
            {
                return true;
            }

            return false;
        }

        public override void Klassenfähigkeit(Kämpfer gegner)
        {
            Block += 1;
        }
    }
}
using System;

namespace ConsoleApp2
{
   public abstract class KaempferBase
    {
        public  string Name { get; set; }
        public  double Leben { get; set; }
        public  double Angriffskraft { get; set; }
        public  double Verteidigungskraft { get; set; }
        public  double Geschwindigkeit { get; set; }

        public abstract bool KannFähigkeitBenutzen();
        public abstract void Klassenfähigkeit(KaempferBase gegner);


    }
}
using System;

namespace ConsoleApp2
{
    // basisklasse
    public abstract class Kämpfer
    {
        public string Name { get; set; }
        public double Leben { get; set; }
        public double Angriffskraft { get; set; }
        public double Verteidigungskraft { get; set; }
        public double Geschwindigkeit { get; set; }

        public bool IsAlive
        {
            get { return this.Leben > 0; }
        }


        public abstract bool KannFähigkeitBenutzen();
        public abstract void Klassenfähigkeit(Kämpfer gegner);


    }
}
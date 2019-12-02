using System;

namespace ConsoleApp2
{
    abstract class KaempferBase
    {
        public KaempferBase()
        {
        }
        public virtual string Name { get; set; }
        public virtual double Leben { get; set; }
        public virtual double Angriffskraft { get; set; }
        public virtual double Verteidigungskraft { get; set; }
        public virtual double Geschwindigkeit { get; set; }



        public abstract void Fähigkeit();

        public virtual void Angriff(KaempferBase gegner)
        {
            double schaden = this.Angriffskraft * (1 - (gegner.Verteidigungskraft / 100));
            gegner.Leben = gegner.Leben - schaden;
            Console.WriteLine("{0} macht {1} schaden ", this.Name, schaden);
            Console.WriteLine("{0} hat {1} HP", gegner.Name, gegner.Leben);
        }
    }
}
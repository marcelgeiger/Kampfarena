using System;

namespace ConsoleApp2
{
    abstract class KaempferBase
    {
        public KaempferBase(string name, double atk, double def, double speed, double leben)
        {
            this.Leben = leben;
            this.Angriffskraft = atk;
            this.Geschwindigkeit = speed;
            this.Verteidigungskraft = def;
            this.Name = name;
        }
        public virtual string Name { get; set; }
        public virtual double Leben { get; set; }
        public virtual double Angriffskraft { get; set; }
        public virtual double Verteidigungskraft { get; set; }
        public virtual double Geschwindigkeit { get; set; }



        public abstract void Fähigkeit();

        public virtual void Angriff(KaempferBase gegner)
        {
            double schaden = this.Angriffskraft * (1 -(gegner.Verteidigungskraft / 100));
            Console.WriteLine(this.Name + " macht schaden " + schaden + " an "+ gegner.Name);
            gegner.Leben = gegner.Leben - schaden;
        }

        public abstract double Abwehr();

        //  return angrifskraft - verteidigungskrafft;


    }
}
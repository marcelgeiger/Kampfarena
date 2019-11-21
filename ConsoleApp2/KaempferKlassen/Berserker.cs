using System;

namespace ConsoleApp2
{
    class Berserker : KaempferBase
    {
        public Berserker(string name, double atk, double def, double speed, double leben) : base(name, atk, def, speed, leben)
        {
            this.Leben = leben;
            this.Angriffskraft = atk;
            this.Geschwindigkeit = speed;
            this.Verteidigungskraft = def;
            this.Name = name;
        }

        public override void Fähigkeit()
        {
            
            // Chance auf Doppelschlag
            
            throw new NotImplementedException();
        }

        public override double Abwehr()
        {
            throw new NotImplementedException();
        }


    }
}
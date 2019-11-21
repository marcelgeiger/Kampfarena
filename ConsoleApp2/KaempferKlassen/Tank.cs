using System;

namespace ConsoleApp2
{
    class Tank : KaempferBase
    {
        public Tank(string name, double atk, double def, double speed, double leben) : base(name, atk, def, speed, leben)
        {
        }

        public override void Fähigkeit()
        {
            // Chance einen Angriff komplett zu blocken
            // leben erhöht
            // 
            throw new NotImplementedException();
        }

        public override void Angriff(KaempferBase gegner)
        {
            throw new NotImplementedException();
        }


        public override double Abwehr()
        {
            throw new NotImplementedException();
        }


   
    }
}
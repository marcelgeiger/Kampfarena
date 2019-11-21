using System;

namespace ConsoleApp2
{
    class Magier : KaempferBase
    {
        public override void Fähigkeit()
        {
            // großer burst DMG, ignoriert DEF, 40%??
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


        public Magier(string name, double atk, double def, double speed, double leben) : base(name, atk, def, speed, leben)
        {
        }
    }
}
using System;

namespace ConsoleApp2
{
    class Schurke : KaempferBase
    {
        Random rnd = new Random();
        
        //Leben
        //Angriff
        //Def
        //Gesch
        //

        public Schurke(string name, double atk, double def, double speed, double leben) : base(name, atk, def, speed, leben)
        {
            
        }

        public override void Fähigkeit()
        {
            // weicht aus

        }

        public override void Angriff(KaempferBase gegner)
        {
            //double schaden;
            ////33% kritischer treffer = 2 * Schaden
            //if (rnd.Next(0, 2) == 0)
            //{

            //    // 1.8 - 2 facher schaden
            //    return schaden = Angriffskraft * (rnd.Next(8,10) /10) * 2;
            //}
   
            //return schaden = this.Angriffskraft - gegner.Abwehr();
        }

        public override double Abwehr()
        {
            double block;
            // hat weniger grundverteidigung
            return block = this.Verteidigungskraft * 0.7;
        }


    }
}
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
    }
}
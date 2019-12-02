using System;
using ConsoleApp2.KaempferKlassen;

namespace ConsoleApp2
{
    class KampfArena
    {
        private Fähigkeiten _fähigkeit;

        private KaempferBase _krieger1;
        private KaempferBase _krieger2;

        public KampfArena(KaempferBase k1, KaempferBase k2)
        {
            _krieger1 = k1;
            _krieger2 = k2;

        }
        



        public void Attack(KaempferBase angreifer, KaempferBase gegner)
        {
            if (gegner is Tank)
            {
                
            }

            if (angreifer.KannFähigkeitBenutzen())
            {
                angreifer.Klassenfähigkeit(gegner);
            }
            else
            {
                double schaden = angreifer.Angriffskraft * (1 - (gegner.Verteidigungskraft / 100));
                gegner.Leben = gegner.Leben - schaden;
                Console.WriteLine("{0} macht {1} schaden ", angreifer.Name, schaden);
                Console.WriteLine("{0} hat {1} HP", gegner.Name, gegner.Leben);
            }
         
                
           
        }
        
        public void Fight()
        {
            var zweiter = (ErsterDerZuschlägt() == _krieger1) ? _krieger2 : _krieger1;


            Attack(ErsterDerZuschlägt(), zweiter);
            if (zweiter.Leben > 0)
            {
                Attack(zweiter, ErsterDerZuschlägt());
                if (ErsterDerZuschlägt().Leben < 0)
                {
                    Console.WriteLine("{0} hat gewonnen", zweiter.Name);
                    return;
                }
            }
            else
            {
                Console.WriteLine("{0} hat gewonnen", ErsterDerZuschlägt().Name);
                return;
            }
            // rekusiver Aufruf

            Fight();
        }

        KaempferBase ErsterDerZuschlägt()
        {
            if (_krieger1.Geschwindigkeit > _krieger2.Geschwindigkeit)
            {
                return _krieger1;
            }
            else if (_krieger2.Geschwindigkeit > _krieger1.Geschwindigkeit)
            {
                return _krieger2;
            }
            else
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 1);
                if (number == 0)
                {
                    return _krieger1;
                }
                else
                {
                    return _krieger2;
                }
            }
        }
    }
}
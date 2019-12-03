using System;
using System.Threading;
using ConsoleApp2.KaempferKlassen;

namespace ConsoleApp2
{
    class KampfArena
    {
        private Fähigkeiten _fähigkeit;

        private Kämpfer _krieger1;
        private Kämpfer _krieger2;

        public KampfArena(Kämpfer k1, Kämpfer k2)
        {
            _krieger1 = k1;
            _krieger2 = k2;

        }

        public void Attack(Kämpfer angreifer, Kämpfer gegner)
        {

            if (gegner is Tank)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 9) < 5)
                {
                    Console.WriteLine("{0} ist bereit und wird jeden Angrif blockieren\n{1} versucht es garnicht erst und positioniert sich neu", gegner.Name, angreifer.Name);
                    Console.WriteLine("_______________________________________________________________________________");
                    return;
                }
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
                Console.WriteLine("_______________________________________________________________________________");
            }
        }

        public void Fight1()
        {
            var zweiter = (ErsterDerZuschlägt() == _krieger1) ? _krieger2 : _krieger1;


            Attack(ErsterDerZuschlägt(), zweiter);
            if (zweiter.Leben >= 0)
            {
                Attack(zweiter, ErsterDerZuschlägt());
                if (ErsterDerZuschlägt().Leben <= 0)
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


            Fight();
        }
        
        public void Fight()
        {
            var erster = ErsterDerZuschlägt();
            var zweiter = (erster == _krieger1) ? _krieger2 : _krieger1;
          
            Thread.Sleep(1000);

            Attack(erster, zweiter);
            if (zweiter.IsAlive)
            {
                Attack(zweiter, erster);
                if (erster.IsAlive)
                {
                    Fight();
                }
                else
                {
                    Console.WriteLine("{0} hat gewonnen", zweiter.Name);
                }
            }
            else
            {
                Console.WriteLine("{0} hat gewonnen", erster.Name);
            }
        }
        

        Kämpfer ErsterDerZuschlägt()
        {
            if (_krieger1.Geschwindigkeit == _krieger2.Geschwindigkeit)
            {
                Random rnd = new Random();
                return (rnd.Next(0, 1) == 0) ? _krieger1 : _krieger2;
            }

            if (_krieger1.Geschwindigkeit > _krieger2.Geschwindigkeit)
            {
                return _krieger1;
            }
            else return _krieger2;
        }
    }
}
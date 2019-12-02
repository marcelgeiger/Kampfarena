using System;

namespace ConsoleApp2
{
    class KampfArena
    {
        private KaempferBase _krieger1;
        private KaempferBase _krieger2;

        public KampfArena(KaempferBase krieger1, KaempferBase krieger2)
        {
            _krieger1 = krieger1;
            _krieger2 = krieger2;
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
        
        public void Fight()
        {

            KaempferBase erster = ErsterDerZuschlägt();
            KaempferBase zweiter;

            // jean

            if (erster == _krieger1)
            {
                zweiter = _krieger2;
            }
            else
            {
                zweiter = _krieger1;
            }

            erster.Angriff(zweiter);
            Console.WriteLine("");
            if (zweiter.Leben <= 0)
            {
                Console.WriteLine((zweiter.Name + " is dead"));
                return;
            }
            zweiter.Angriff(erster);
            if (erster.Leben <= 0)
            {
                Console.WriteLine((erster.Name + " is dead"));
                return;
            }
            // rekusiver Aufruf
            Fight();
        }
    }
}
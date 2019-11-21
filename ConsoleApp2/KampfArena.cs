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


        KaempferBase ErsterDerZuschlägt(KaempferBase w1, KaempferBase w2)
        {
            if (w1.Geschwindigkeit > w2.Geschwindigkeit)
            {
                return w1;
            }
            else if (w2.Geschwindigkeit > w1.Geschwindigkeit)
            {
                return w2;
            }
            else
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 1);
                if (number == 0)
                {
                    return w1;
                }
                else
                {
                    return w2;
                }
            }
        }

        void Fight(KaempferBase w1, KaempferBase w2)
        {
            w1.Angriff(w2);
            w2.Angriff(w1);
            // test ob sich hier was ändert im push

            //if (ErsterDerZuschlägt(w1, w2).Angriff(w2) == w1.Angriff(w2))
            //{
            //    w2.Angriff(w1);
            //}
            //else
            //{
            //    w1.Angriff(w2);
            //}
        }


        bool CheckGewonnen()
        {
            bool sieger = _krieger1.Leben <= 0 || _krieger2.Leben <= 0;

            Console.WriteLine("Spieler 1 Leben: " + _krieger1.Leben);
            Console.WriteLine("Spieler 2 Leben: " + _krieger2.Leben);
            return sieger;
        }

      public  void StartKampf()
        {
            do
            {
                Fight(_krieger1, _krieger2);

            } while (!CheckGewonnen());

        }

    }
}
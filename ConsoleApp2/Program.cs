using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;
using ConsoleApp2.KaempferKlassen;

namespace ConsoleApp2
{
    class Program
    {
        KaempferFactory factory = new KaempferFactory();

        static void Main(string[] args)
        {
            List<Kämpfer> _arenaKämpfer = new List<Kämpfer>();
            KaempferFactory factory = new KaempferFactory();

            Program p = new Program();


            Kämpfer k1 = new Tank(200,50,30,30,"Tank");
            Kämpfer k2 = new Magier(200,50,30,30,"Magier");
            Kämpfer k3 = new Schurke(200,50,30,30,"Schurke");
            Kämpfer k4 = new Berserker(200,50,30,30,"Berserker");



            KampfArena arena = new KampfArena(_arenaKämpfer[0], _arenaKämpfer[1]);
            arena.Fight();
            
            
            Console.WriteLine("Willkommen in der Kampfarena \nMöchtest du gegen einen Freund antreten (1) oder dein Glück allein in der Arena versuchen (2) ?");

            int.TryParse(Console.ReadLine(), out int antwort);

            Kämpfer k5;
            Kämpfer k6;

            Console.WriteLine("Ihr möchtet also gegen einander antreten \nSpieler eins Bitte wähle nun deine Kämpferklasse");
            k5 = p.DatenfürkriegerSammeln();
            Console.WriteLine("Spieler 2 ist nun an der reihe");
            k6 = p.DatenfürkriegerSammeln();

            Console.WriteLine("Mögen die Spiele beginnen");

        }



        void AlleinSpielen()
        {
            int punkteZuVergeben = 150;

            Console.WriteLine("Um dich in der Arena behaupten zu können musst du dir zuerst einen Helden erstellen");
            Console.WriteLine("(1) = Berserker\n(2) = Magier\n(3) = Schurke \n(4) = Tank \nInfos zu den jeweiligen Klassen findest du unter (5)");
            Console.WriteLine("Super, nun gib deinem Helden einen Namen");
            string name = Console.ReadLine();
            Console.WriteLine("Dein Held braucht einen guten mix aus Attributen, vergebe nun 150 Punkte auf folgende Werte. Dein Held startet jedoch mit 100 Leben");
            
            Console.WriteLine("[100]Leben erhöhen ? >> Punkte zu vergeben {0}",punkteZuVergeben);
           // CheckEingabe(punkteZuVergeben,Console.ReadLine());
            double hp = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("[0]Angriff erhöhen ? >> Punkte zu vergeben {0}",punkteZuVergeben);
            double atk = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("[0]Abwehr erhöhen ? >> Punkte zu vergeben {0}",punkteZuVergeben);
            double def = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("[0]Geschwindikeit erhöhen ? >> Punkte zu vergeben {0}",punkteZuVergeben);
            double speed = Convert.ToDouble(Console.ReadLine());

        }

        //TODO
        //int CheckEingabe(int maxwert, string eingabe)
        //{
        //    double.TryParse(eingabe, out double wert );
        //    do
        //    {
        //    } while (b);

        //}

        

        Kämpfer DatenfürkriegerSammeln()
        {
            Console.WriteLine("(1) = Berserker\n(2) = Magier\n(3) = Schurke \n(4) = Tank \nInfos zu den jeweiligen Klassen findest du unter (5)");

            int.TryParse(Console.ReadLine(), out int klassentyp);

            Console.WriteLine("Du kannst deinem Krieger nun einen Namen geben.\nAußerdem erhälst du 100 Punkte die frei vergeben werden können um deinen Krieger zu stärken.");
            string name = Console.ReadLine();
            Console.WriteLine("Wähle weise denn die Reihenfolge bestimmt die stärken deines Kriegers");
            Console.WriteLine("Die standart Werte eines jeden Kriegers noch bevor seine Klassenfähigkeit gezählt wird sind \nLeben[0]\nAngriff[0]\nVerteidigung[0]\nGeschwindikeit[0]");
            Console.WriteLine("Verteile nun deine Werte");
            int.TryParse(Console.ReadLine(), out int hp);
            int.TryParse(Console.ReadLine(), out int atk);
            int.TryParse(Console.ReadLine(), out int def);
            int.TryParse(Console.ReadLine(), out int speed);
            return factory.SpielerErstellen(hp, atk, speed, def, name, klassentyp);
        }
    }
}

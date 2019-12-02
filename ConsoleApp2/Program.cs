using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            KaempferBase k3;
            KaempferBase k4;

            KaempferBase k1 = new Berserker() { Angriffskraft = 40, Geschwindigkeit = 30, Leben = 200, Name = "tester1", Verteidigungskraft = 25 };
            KaempferBase k2 = new Berserker() { Angriffskraft = 35, Geschwindigkeit = 31, Leben = 220, Name = "tester2", Verteidigungskraft = 30 };




            //   arena.Fight(k1, k2);

            Console.WriteLine("Willkommen in der Kampfarena \nMöchtest du gegen einen Freund antreten (1) oder dein Glück allein in der Arena versuchen (2) ?");

            int.TryParse(Console.ReadLine(), out int antwort);


            Console.WriteLine("Ihr möchtet also gegen einander antreten \nSpieler eins Bitte wähle nun deine Kämpferklasse");
            k3 = p.DatenfürkriegerSammeln();
            Console.WriteLine("Spieler 2 ist nun an der reihe");
            k4 = p.DatenfürkriegerSammeln();

            KampfArena arena = new KampfArena(k3, k4);
            arena.Fight();


        }

        KaempferBase DatenfürkriegerSammeln()
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
            return SpielerErstellen(hp, atk, speed, def, name, klassentyp);

        }


        private KaempferBase SpielerErstellen(int hp, int atk, int speed, int def, string name, int klassenTyp)
        {

            KaempferBase kaempfer;

            switch (klassenTyp)
            {
                case 1:
                    return kaempfer = new Berserker() { Name = name, Angriffskraft = atk, Geschwindigkeit = speed, Leben = hp, Verteidigungskraft = def };
                case 2:
                    return kaempfer = new Magier() { Name = name, Angriffskraft = atk, Geschwindigkeit = speed, Leben = hp, Verteidigungskraft = def };
                case 3:
                    return kaempfer = new Schurke() { Name = name, Angriffskraft = atk, Geschwindigkeit = speed, Leben = hp, Verteidigungskraft = def };
                case 4:
                    return kaempfer = new Tank() { Name = name, Angriffskraft = atk, Geschwindigkeit = speed, Leben = hp, Verteidigungskraft = def };
                default:
                    Console.WriteLine("falsche eingabe");
                    return null;
            }
        }


        // je höher die schwierigkeit je mehr gegner sind zu besiegen vielleicht?
        private List<KaempferBase> ComputerGegnerErstellen(int schwierigkeit)
        {
            List<KaempferBase> gegner = new List<KaempferBase>();

            return gegner;

        }



    }
}

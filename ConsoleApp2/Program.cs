using System;
using System.Security.Principal;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Willkommen in der Kampfarena \nMöchtest du gegen einen Freund antreten (1) oder dein Glück allein in der Arena versuchen (2)?");

            KaempferBase marcel = new Berserker("marcel", 60, 20, 20, 1000 );
            KaempferBase johnny = new Berserker("johnny", 80, 10, 10, 500);
            KampfArena krefelderring = new KampfArena(marcel, johnny);
            krefelderring.StartKampf();


        }
    }
}

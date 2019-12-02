using System;

namespace ConsoleApp2
{
    class Berserker : KaempferBase
    {
        public Berserker(int leben, int atk)
        {
            this.Leben = leben;
            this.Angriffskraft = atk * 1.2;
        }

        public override void Fähigkeit()
        {
            // berserker bekommen 20% mehr auf stärke
            
            throw new NotImplementedException();
        }
    }
}
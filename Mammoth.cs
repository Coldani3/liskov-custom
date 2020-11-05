using System;

namespace liskovcustom
{
    public class Mammoth : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("MUROOOOOWWUUU");
        }
        
        public override bool Alive()
        {
            return false;
        }
    }
}
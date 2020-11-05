using System;

namespace liskovcustom
{
    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Woof");
        }
    }
}
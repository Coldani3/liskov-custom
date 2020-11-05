using System;

namespace liskovcustom
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Born");
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("breathe");
        }
    }
}
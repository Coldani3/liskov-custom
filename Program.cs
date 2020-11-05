using System;

namespace liskovcustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void DoTheThing(Animal animal)
        {
            animal.MakeNoise();
        }
    }
}

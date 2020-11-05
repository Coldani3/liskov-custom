using System;

namespace liskovcustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Dog();
            Animal animal3 = new Cat();

            animal1.MakeNoise();
            animal2.MakeNoise();
            animal3.MakeNoise();
        }

        public void DoTheThing(Animal animal)
        {
            animal.MakeNoise();
        }
    }
}

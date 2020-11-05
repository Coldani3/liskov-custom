using System;

namespace liskovcustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Dog();
            //error version
            //Animal animal3 = new Mammoth();
            //success version
            Animal animal3 = new Cat();

            if (animal1.Alive() && animal2.Alive() && animal3.Alive())
            {
                DoTheThing(animal1);
                DoTheThing(animal2);
                DoTheThing(animal3);
            }
            else
            {
                Console.WriteLine("logic flow break, your program would crash");
            }
        }

        public static void DoTheThing(Animal animal)
        {
            animal.MakeNoise();
        }
    }
}

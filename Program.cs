using System;

namespace liskovcustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Dog();
            //error version, mammoth returns different sort of value for .Alive() than the base
            //yes the other animals do something different for making noise but if they all did the exact same thing there'd
            //be no point to extending the first class in the first place and nothing to demonstrate LSP with
            //################################
            //Animal animal3 = new Mammoth();

            //success version
            Animal animal3 = new Cat();

            if (animal1.Alive() && animal2.Alive() && animal3.Alive())
            {
                DoTheThing(animal1);
                DoTheThing(animal2);
                DoTheThing(animal3);
                Console.WriteLine("followed liskov");
            }
            else
            {
                Console.WriteLine("logic flow break, your program would crash");
                throw new Exception("logic break");
            }
        }

        public static void DoTheThing(Animal animal)
        {
            animal.MakeNoise();
        }
    }
}

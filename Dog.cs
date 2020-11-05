using System;
//this class is for the dog features
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

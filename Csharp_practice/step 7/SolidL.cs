using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_7
{
class Bird
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    interface IFlyable
    {
        void Fly();
    }

    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }

    class Penguin : Bird
    {
        public Penguin(string name) : base(name)
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming");
        }
    }

    class BirdActions
    {
        public void MakeBirdEat(Bird bird)
        {
            bird.Eat();
        }

        public void MakeBirdFly(IFlyable bird)
        {
            bird.Fly();
        }
    }

    class SolidL
    {
       public static void Main()
        {
            Sparrow sparrow = new Sparrow("Sparrow");
            Penguin penguin = new Penguin("Penguin");

            BirdActions actions = new BirdActions();

            actions.MakeBirdEat(sparrow);
            actions.MakeBirdEat(penguin);

            actions.MakeBirdFly(sparrow);

            penguin.Swim();
        }
    }
}


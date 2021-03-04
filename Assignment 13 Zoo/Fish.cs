using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Fish : Animal
    {

        public Fish(string Name, int Age, int Legs)
        {
            this.Name = Name;
            this.Age = Age;
            this.Legs = Legs;
        }
        public void Swim()
        {
            Console.WriteLine("I SWIM!");
        }
        public override void Speak()
        {
            Console.WriteLine("Choke Intensifies");
        }
    }
}

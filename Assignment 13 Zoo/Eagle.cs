using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Eagle : Animal
    {
        public Eagle(string Name,int Age, int Legs)
        {
            this.Name = Name;
            this.Age = Age;
            this.Legs = Legs;
        }
        public void Fly()
        {
            Console.WriteLine("I FLY!");
        }
        public override void Speak()
        {
            Console.WriteLine("Bark");
        }
    }
}

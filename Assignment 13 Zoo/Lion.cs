using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Lion : Animal
    {

        public Lion(string Name, int Age, int Legs)
        {
            this.Name = Name;
            this.Age = Age;
            this.Legs = Legs;
        }
        public void Run()
        {
            Console.WriteLine("I RUN!");
        }
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}

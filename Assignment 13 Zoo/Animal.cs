using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Animal
    {
        protected string Name;
        protected string Species;
        protected int Age;
        protected int Legs;

        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetSpecies()
        {
            return Species;
        }
        public int GetLegs()
        {
            return Legs;
        }
        public virtual void Speak()
        {
 
        }
    }
}

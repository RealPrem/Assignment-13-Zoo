using System;

namespace Assignment_13_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] Zoo = new Animal[3];
            Zoo[0] = new Lion("Actual Lion", 10, 4);
            Lion ActualLion = (Lion) Zoo[0];
            Zoo[1] = new Fish("Actual Fish", 10, 10);
            Zoo[2] = new Eagle("Actual Eagle", 10, 2);

            for (int i = 0; i < Zoo.Length; i += 1)
            {
                Console.WriteLine("{0} {1}", Zoo[i].GetName(), Zoo[i].GetAge());
                Zoo[i].Speak();
            }
            
        }
    }
}

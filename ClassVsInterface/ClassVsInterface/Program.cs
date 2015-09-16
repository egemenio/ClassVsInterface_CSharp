using System;

namespace ClassVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable person = new Person();
            IMovable bird = new Bird();
            IMovable fish = new Fish();

            //We can add different class instances which implement 
            //same interface to one array 
            IMovable[] movables = new IMovable[3];
            movables[0] = person;
            movables[1] = bird;
            movables[2] = fish;

            foreach (var movable in movables)
            {
                movable.Move();
            }

            Console.ReadLine();
        }
    }
}
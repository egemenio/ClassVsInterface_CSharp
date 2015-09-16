using System;

namespace ClassVsInterface
{
    class Fish : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Fish swims.");
        }
    }
}
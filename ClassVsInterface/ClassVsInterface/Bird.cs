using System;

namespace ClassVsInterface
{
    class Bird : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bird flies.");
        }
    }
}
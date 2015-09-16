using System;

namespace ClassVsInterface
{
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Person walks.");
        }
    }
}
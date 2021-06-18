using System;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman s1 = new Footballer();
            Sportsman s2 = new ValleyballPlayer();
            s1.Play();
            s2.Play();
            Console.Read();
        }
    }
}

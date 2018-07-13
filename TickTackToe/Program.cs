using System;

namespace TickTackToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.choseNumber();
            Console.ReadLine();
        }
    }
}

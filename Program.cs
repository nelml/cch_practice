using System;

namespace cch
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("ひろし", 2100);

            int hp = player.GetHp();

            int newHP = hp - 2000;

            player.SetHp(newHP);

            Console.WriteLine("HPは" + player.GetHp());

        }
    }
}

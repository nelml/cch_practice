using System;
using System.Collections.Generic;
using System.Text;

namespace cch
{
    class Player
    {
        private string name;
        private int hp;

        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;

        }

        public void SetHp(int hp)
        {
            this.hp = hp;
            if(this.hp < 0)
            {
                this.hp = 0;
            }


        }

        public int GetHp()
        {
            return this.hp;
        }

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");

        }
    }
}

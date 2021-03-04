using System;
using System.Collections.Generic;
using System.Text;

namespace cch
{
    class Player
    {
        public string name;
        public int hp;

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

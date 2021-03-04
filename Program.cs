using System;

namespace cch
{
    class Program
    {
        static void Main(string[] args)
        {
            int math = 80;
            int english = 66;
            int history = 95;

            float average = (math + english + history) / 3.0f;
            Console.WriteLine("平均は" + average + "点です。");


        }
    }
}

using System;

namespace ООПФТД
{
    class Program
    {
        static void Main(string[] args)
        {
            Gold x1 = new Gold(-2f, 2f);
            Gold x2 = new Gold(-8f, 0f);

            Console.Write("Экстремум для функции f(x)=(x+1)^3+5*x^2\n");
            Console.Write(x1.print());
            Console.Write(x2.print());
        }
    }
}

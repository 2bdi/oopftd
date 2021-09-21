using System;

namespace ООПФТД
{
    class Gold
    {
        public float result;
        public float min;
        public float max;
        public float a;
        public float b;

        public void print()
        {
            Console.Write("Экстремумы для функции f(x)=(x+1)^3+5*x^2");
            Console.Write($"[{this.a};{this.b}]");
            Console.Write($" при x: {this.result:0.000}");
            Console.Write($"max: {this.max:0.000}");
            Console.Write($"min: {this.min:0.000}");
        }

        public Gold(float a, float b)
        {
            float e = 0.001f;
            float x1, x2, y1, y2;
            this.a = a;
            this.b = b;
            while(!(Math.Abs(b - a) < e))
            {
                x1 = b - ((b - a) / 1.618f);
                x2 = a + ((b - a) / 1.618f);
                y1 = MathF.Pow(x1 + 1, 3) + (5 * x1 * x1);
                y2 = MathF.Pow(x2 + 1, 3) + (5 * x2 * x2);      
            }
            if (y1 >= y2)
                a = x1;
            else
                b = x2;
            this.min = (a + b) / 2;
            a = this.a;
            b = this.b;
            if (y1 <= y2)
                a = x1;
            else
                b = x2;
            this.max = (a + b) / 2;
            this.result = MathF.Pow(x1 + 1, 3) + (5 * MathF.Pow(x1, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gold x1 = new Gold(-2f, 2f);
            Gold x2 = new Gold(-8f, 0f);

            x1.print();
            x2.print();
        }
    }
}

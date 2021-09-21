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
            Console.Write($"[{this.a};{this.b}]\n");
            Console.Write($" при x: {this.result:0.000}\n");
            Console.Write($"max: {this.max:0.000}\n");
            Console.Write($"min: {this.min:0.000}\n");
        }

        public Gold(float a, float b)
        {
            float x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            this.a = a;
            this.b = b;
            while(!(Math.Abs(b - a) < 0.001f))
            {
                x1 = b - ((b - a) / 1.618f);
                x2 = a + ((b - a) / 1.618f);
                y1 = MathF.Pow(x1 + 1, 3) + (5 * x1 * x1);
                y2 = MathF.Pow(x2 + 1, 3) + (5 * x2 * x2);  
                if (y1 >= y2)
                {
                    a = x1;
                    this.min = (a + this.b) / 2;
                } else {
                    b = x2;
                    this.max = (this.a + b) / 2;
                }
            }
            this.result = MathF.Pow(this.max + 1, 3) + (5 * MathF.Pow(this.min, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gold x1 = new Gold(-2f, 2f);
            Gold x2 = new Gold(-8f, 0f);

            Console.Write("Экстремумы для функции f(x)=(x+1)^3+5*x^2\n");
            x1.print();
            x2.print();
        }
    }
}

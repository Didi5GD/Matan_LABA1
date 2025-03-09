using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matan_LABA1
{
    public class Basa_three
    {

        // Функция
        public float f(float x)
        {
            return (float)(100*Math.Pow(x, 2) - 10000 * x -2);
        }
        // Производная от функции
        public float df(float x)
        {
            return (float)(200*x-10000);
        }
        public float ddf(float x)
        {
            return (float)(200);
        }
        public float phi(float x_past, float mod)
        {
            float lambda;
            if (df(x_past) > 0)
            {
                lambda = -1.0f / mod;
            }
            else
            {
                lambda = 1.0f / mod;
            }
            return x_past + lambda * f(x_past);
        }
        public float MethodSimpleIteration(float a, float b, float epsilon)
        {
            float x_n = b;
            float x_past = a;
            float lam = 0;

            float[] ns = { Math.Abs(df(a)), Math.Abs(df(b)) };
            float m = ns.Min();
            float M = ns.Max();

            while (Math.Abs(x_n - x_past) > epsilon)
            {

                if (df(x_past) > 0)
                {
                    lam = -(1 / M);
                }
                else if (df(x_past) < 0)
                {
                    lam = 1 / m;
                }
                x_past = x_n;
                x_n = x_past + lam * f(x_past);
                Console.WriteLine(x_n.ToString("F20"));
            }
            return (x_n);
        }
        /// <param name="side"> Accepts the string: "left" or "right" </param>
        public float MethodNewton(float a, float b, string side, float epsilon)
        {
            float x_n; // В формулах x_n
            float x_past; // В формулах x_n-1
            switch (side)
            {
                case "left":
                    x_past = a;
                    x_n = x_past - (f(x_past) / df(x_past));
                    while (Math.Abs(x_n - x_past) > epsilon)
                    {
                        x_past = x_n;
                        x_n = x_past - (f(x_past) / df(x_past));
                        Console.WriteLine(x_n.ToString("F20"));
                    }

                    return x_n;
                case "right":

                    x_past = b;
                    x_n = b - (f(b) / df(b));
                    while (Math.Abs(x_n - x_past) > epsilon)
                    {
                        x_past = x_n;
                        x_n = x_past - (f(x_past) / df(x_past));
                        Console.WriteLine(x_n.ToString("F20"));

                    }
                    return x_n;
                default: break;
            }
            return 0;
        }

        public float MethodChord(float a, float b, float epsilon)
        {
            float x_n = b;
            float x_past = a;

            if (ddf(b) * f(b) >= 0)
            {
                x_past = a;
                x_n = b;

                while (Math.Abs(x_n - x_past) > epsilon)
                {
                    x_past = x_n;
                    float x_f = (f(x_past) - f(a)) / (x_past - a);
                    x_n = x_past - (f(x_past) / x_f);
                    Console.WriteLine(x_n.ToString("F20"));
                }
            }
            else if (ddf(a) * f(a) >= 0)
            {
                x_past = b;
                x_n = a;

                while (Math.Abs(x_n - x_past) > epsilon)
                {
                    x_past = x_n;
                    float x_f = (f(b) - f(x_past)) / (b - x_past);
                    x_n = x_past - (f(x_past) / x_f);
                    Console.WriteLine(x_n.ToString("F20"));
                }
            }
            return (x_n);
        }

    }
}

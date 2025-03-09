using Matan_LABA1;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MATAN_LABA1
{
    internal static class Program
    {
    public static void Main()
        {
            var delta = 1e-45f;
            Console.WriteLine($"Точность {delta}\n");
            //Class a = new Class();
            //Console.WriteLine($"Метод Ньютона [-2,1] слева направо {a.MethodNewton(-2,-1,"left", delta).ToString("F20")}");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод Ньютона [-2,1] справа налево {a.MethodNewton(-2, -1, "right", delta).ToString("F20")}");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод Ньютона [1,2] слева направо {a.MethodNewton(1, 2, "left", delta).ToString("F20")}");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод Ньютона [1,2] справа налево {a.MethodNewton(1, 2, "right", delta).ToString("F20")}");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод Ньютона [8,9] слева направо {a.MethodNewton(8, 9, "left", delta).ToString("F20")}");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод Ньютона [8,9] справо налево {a.MethodNewton(8, 9, "right", delta).ToString("F20")}");

            //Console.WriteLine("\n+++++++++++++++++++++++++\n");

            //Console.WriteLine($"Метод простых итераций [-2,1] {a.MethodSimpleIteration(-2, -1, delta).ToString("F20")} ");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод простых итераций [1,2] {a.MethodSimpleIteration(1, 2, delta).ToString("F20")} ");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод простых итераций [8,9] {a.MethodSimpleIteration(8, 9, delta).ToString("F20")} ");

            //Console.WriteLine("\n+++++++++++++++++++++++++\n");

            //Console.WriteLine($"Метод хорд [-2,-1] {a.MethodChord(-2, -1, delta).ToString("F20")} ");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод хорд [1,2] {a.MethodChord(1, 2, delta).ToString("F20")} ");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Метод хорд [8,9] {a.MethodChord(8, 9, delta).ToString("F20")} ");

            Basa_three b = new Basa_three();
            Console.WriteLine($"Метод Ньютона [91,101] слева направо {b.MethodNewton(91, 101, "left", delta).ToString("F20")}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Метод Ньютона [91,101] справа налево {b.MethodNewton(91, 101, "right", delta).ToString("F20")}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Метод простых итераций [91,101] {b.MethodSimpleIteration(91, 101, delta).ToString("F20")} ");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Метод хорд [91,101] {b.MethodChord(91, 101, delta).ToString("F20")} ");











        }



    }
}
using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Console;
/// <summary>
/// Соколова Диана БПИ 202

///Написать метод, вычисляющий значение функции G=F(X)
///𝐺=
///(sin⁡(𝜋/2),𝑋≤0.5
///sin⁡((𝜋∙(𝑥−1))/2),𝑋>0.5

/// </summary>
namespace A
{

    class Program
    {
        const double eps = 1e-12;
        static double F(double x)
        {
            if (x - 0.5 < eps) return Math.Sin(Math.PI / 2);
            return Math.Sin(Math.PI*(x-1) / 2);
        }
        static void Main(string[] args)
        {
            double x;
            if (!double.TryParse(ReadLine(), out x) )
            {
                WriteLine("Ошибка");
                return;
            }
            WriteLine(string.Format("{0:f30}",F(x)));
        }
    }
}

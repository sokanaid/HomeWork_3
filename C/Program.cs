using System;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Console;
/// <summary>
/// Соколова Диана БПИ 202

///Написать метод, вычисляющий логическое значение функции G=F(X,Y).
///Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, и результат равен false, если точка с координатами (X,Y)
///не попадает в фигуру G. Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.


/// </summary>
namespace A
{

    class Program
    {
        const double eps = 1e-12;
        static bool InCircul(double x,double y,double R) =>(x*x+y*y-R*R)<eps;
        static bool AbouveLine1(double x, double y) => y - x > -eps;
        static bool AbouveLine2( double y) => y> -eps;
        static bool InFigure(double x, double y) => InCircul(x, y, 2) && AbouveLine1(x, y) && AbouveLine2(y);
        static void Main(string[] args)
        {
            double x, y;
            if (!double.TryParse(ReadLine(),out x) || !double.TryParse(ReadLine(), out y))
            {
                WriteLine("Ошибка");
                return;
            }
            if (InFigure(x, y)) WriteLine("Точка внутри заданной фигуры");
            else WriteLine("Точка не входит в заданную область");
        }
    }
}

using System;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
/// <summary>
/// Соколова Диана БПИ 202

///(***) Трехзначным целым числом кодируется номер аудитории в учебном корпусе. 
///Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже. 
///Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет минимальный номер внутри этажа. 
///Если таких аудиторий несколько - вывести любую из них. 


/// </summary>
namespace A
{

    class Program
    {
        static bool IsCorrect(out int x) => int.TryParse(ReadLine(), out x) && (100<=x && x<1000);
        static int GetAns(int a,int b,int c)
        {
            int x=a%100, y=b%100, z=c%100;
            if (x < y && x < z) return a;
            else if (y < z && y < x) return b;
            else return c;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            if (!IsCorrect(out a) || !IsCorrect(out b) || !IsCorrect(out c))
            {
                WriteLine("ошибка");
                return;
            }
            WriteLine(GetAns(a, b, c));

        }
    }
}

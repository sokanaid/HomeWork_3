using System;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Console;
/// <summary>
/// Соколова Диана БПИ 202

////Написать метод, преобразующий число переданное в качестве параметра в число, записанное теми же цифрами, но идущими в обратном порядке. 
///Например, 1024 - > 4201, 120-> 21

/// </summary>
namespace A
{

    class Program
    {
        static int GetAns(int n)

        {
            int ans = 0;
            while (n > 0)
            {
                ans *= 10;
                ans += n % 10;
                n /= 10;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int n;
            if (!int.TryParse(ReadLine(), out n))
            {
                WriteLine("Ошибка");
                return;
            }
            WriteLine(GetAns(n));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, S, R, r, a;
            char ps;
            Console.WriteLine("Привет");
            Console.WriteLine("Как будем находить площадь(S) b периметр(P)?");
            Console.WriteLine("1) По радиусу описанной окружности (R)");
            Console.WriteLine("2) По радиусу вписанной окружности (r)");
            Console.WriteLine("3) По стороне (a)");
            Console.WriteLine("Введи букву чтобы выбрать способ");
            ps = char.Parse(Console.ReadLine());
            switch (ps)
            {
                case 'R':
                    Console.Write("Введите значение радиуса: ");
                    R = double.Parse(Console.ReadLine());
                    a = (double)((R * 3) / (Math.Pow(3, (1.0 / 3))));
                    S = (double)(((Math.Pow(a, 2)) * (Math.Pow(3, (1.0 / 3)))) / 4);
                    P = a + a + a;
                    Console.WriteLine("Пощадь: {0}", S);
                    Console.WriteLine("Периметр: {0}", P);
                    break;

                case 'r':
                    Console.Write("Введите значение радиуса: ");
                    r = double.Parse(Console.ReadLine());
                    R = 2 * r;
                    a = (double)((R * 3) / (Math.Pow(3, (1.0 / 3))));
                    S = (double)(((Math.Pow(a, 2)) * (Math.Pow(3, (1.0 / 3)))) / 4);
                    P = a + a + a;
                    Console.WriteLine("Пощадь: {0}", S);
                    Console.WriteLine("Периметр: {0}", P);
                    break;

                case 'a':
                    Console.Write("Введите значение стороны: ");
                    a = double.Parse(Console.ReadLine());
                    S = (double)(((Math.Pow(a, 2)) * (Math.Pow(3, (1.0 / 3)))) / 4);
                    P = a + a + a;
                    Console.WriteLine("Площадь: {0}", S);
                    Console.WriteLine("Периметр: {0}", P);
                    break;
            }
            Console.ReadKey();
        }
    }
}

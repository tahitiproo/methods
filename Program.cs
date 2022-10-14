using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        public static void Uravn(int[] arr)
        {
            if ((Math.Pow(arr[1], 2) - 4 * arr[0] * arr[2]) > 0)
            {
                double x_1 = (-arr[1] - Math.Sqrt(Math.Pow(arr[1], 2) - 4 * arr[0] * arr[2])) / (2 * arr[0]);
                double x_2 = (-arr[1] + Math.Sqrt(Math.Pow(arr[1], 2) - 4 * arr[0] * arr[2])) / (2 * arr[0]);
                Console.WriteLine($"{x_1},{x_2}");
            }
            else if ((Math.Pow(arr[1], 2) - 4 * arr[0] * arr[2])==0)
            {
                double x_0 = (-arr[1] / (2 * arr[0]));
                Console.WriteLine($"{x_0}");
            }
            else
            {
                Console.WriteLine("Нет действительных корней");
            }
        }
        public static void Sluchai(ref int[] arra)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            int perem = a;
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            a = Array.IndexOf(arra, a);
            b = Array.IndexOf(arra, b);
            arra[a] = arra[b];
            arra[b] = perem;
            Console.WriteLine(string.Join(",",arra));
        }
        public static int[] BubbleSort(int[] mass)
        {
            int perem;
            for (int i = 0; i<mass.Length; i++)
            {
                for (int j = i + 1; j<mass.Length; j++)
                {
                    if (mass[i]>mass[j])
                    {
                        perem = mass[i];
                        mass[i] = mass[j];
                        mass[j] = perem;
                    }
                }
            }
            return mass;
        
        }
        static void Main(string[] args)
        {
            /*Console.WriteLint("Упражнение 1");
            Console.WriteLine("Введите коэффициенты уравнения: ");
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Uravn(arr);
            Console.WriteLine("Упражнение 2");
            int[] arra = new int[20];
            int i;
            Random rand = new Random();
            for (i = 0; i < arra.Length; i++)
            {
                arra[i] = rand.Next(1,100);
                Console.Write($"{arra[i]},");
            }
            Console.WriteLine();
            Sluchai(ref arra);
            */

            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Сколько чисел будешь сортировать?");
            byte N = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введи ряд чисел который нужно отсортировать");
            int[] massivniy = new int[N];
            for (int i = 0; i < massivniy.Length; i++)
            {
                massivniy[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(massivniy);
            Console.WriteLine("bul`.....bul`.....bul`");
            for (int i = 0; i < massivniy.Length; i++)
            {
                Console.Write($"{massivniy[i]} ");
            }
        }
    }
}

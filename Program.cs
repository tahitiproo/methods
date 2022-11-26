using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Linq;
using System.Security;

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
        static void Swap(ref int x,ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        static int Partition(int[] array,int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for(var i = minIndex; i < maxIndex; i++)
            {
                if(array[i]<array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        static int[] QuickSort(int[] array,int minIndex,int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
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
        public static double MassiveOfDetention(double sum,ref double s1, out double s2, params int[] array)
        {
            foreach(int numbers in array)
            {
                sum += numbers;
                s1 *= numbers;
            }
            s2 = sum / array.Length;
            return sum;
        }
        public struct Dead
        {
            public string imyadeada;
            public int sinyak;
            public string[] cykablyat;
            public Vorch stepvorch;
            public enum Vorch
            {
                Nemoy,
                Uchyoniy,
                Voenniy,
                Vodyatel,
                NaStroykeX_yaril,
            }
            public int DeadiBabka(string imyadeada,int sinyak,Vorch stepvorch,params string[] cykablyat)
            {
                List<string> castrationdeada = new List<string> { "уй","хер","ёб" };
                foreach (string fraza in cykablyat)
                {
                    foreach(string boosh in castrationdeada)
                    {
                        if (fraza.Contains(boosh))
                            sinyak += 1;
                    }
                }
                return sinyak;
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 1");
            Console.WriteLine("Введите коэффициенты уравнения: ");
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Uravn(arr);
            Console.WriteLine("Упражнение 2");
            int[] arra = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arra.Length; i++)
            {
                arra[i] = rand.Next(1,100);
                Console.Write($"{arra[i]},");
            }
            Console.WriteLine();
            Sluchai(ref arra);

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
            Console.WriteLine();
            

            Console.WriteLine("Упражнение 4");
            int[] nabor = { 1, 2, 3, 4, 5, 6, 7 };
            double l = 1;
            double sum = 0;
            Console.WriteLine("{0},{1},{2}",MassiveOfDetention(sum, ref l, out double number, nabor), l,number);
            
            Console.WriteLine("Упражнение 5");
            try
            {
                var dict = new Dictionary<int, string>()
                {
                    [0] =   " ##### \r\n" +
                            "#     #\r\n" +
                            "#    ##\r\n" +
                            "#  #  #\r\n" +
                            "##    #\r\n" +
                            "#     #\r\n" +
                            " ##### ",
                    [1] =   "  ##   \r\n" +
                            " # #   \r\n" +
                            "#  #   \r\n" +
                            "   #   \r\n" +
                            "   #   \r\n" +
                            "   #   \r\n" +
                            "#######",
                    [2] =   "  ###  \r\n" +
                            " #   # \r\n" +
                            "#    # \r\n" +
                            "    #  \r\n" +
                            "   #   \r\n" +
                            "  #    \r\n" +
                            "#######",
                    [3] =   " ##### \r\n" +
                            "#     #\r\n" +
                            "      #\r\n" +
                            " ##### \r\n" +
                            "      #\r\n" +
                            "#     #\r\n" +
                            " ##### ",
                    [4] =   "    ## \r\n" +
                            "   # # \r\n" +
                            "  #  # \r\n" +
                            " #   # \r\n" +
                            "#######\r\n" +
                            "     # \r\n" +
                            "     # ",
                    [5] =   "#######\r\n" +
                            "#      \r\n" +
                            "#      \r\n" +
                            " ##### \r\n" +
                            "      #\r\n" +
                            "     ##\r\n" +
                            "#####  ",
                    [6] =   "  #### \r\n" +
                            " #    #\r\n" +
                            "#      \r\n" +
                            "###### \r\n" +
                            "#     #\r\n" +
                            "#     #\r\n" +
                            " ##### ",
                    [7] =   "#######\r\n" +
                            "      #\r\n" +
                            "     # \r\n" +
                            "    #  \r\n" +
                            "   #   \r\n" +
                            "  #    \r\n" +
                            " #     \r\n",
                    [8] =   " ##### \r\n" +
                            "#     #\r\n" +
                            "#     #\r\n" +
                            " ##### \r\n" +
                            "#     #\r\n" +
                            "#     #\r\n" +
                            " ##### ",
                    [9] =   " ##### \r\n" +
                            "#     #\r\n" +
                            "#     #\r\n" +
                            " ######\r\n" +
                            "      #\r\n" +
                            "#    # \r\n" +
                            " ####  ",
                };
                Console.Write("Введите цифру от 0 до 9: ");
                int w = int.Parse(Console.ReadLine());
                if ((w > 9)|(w < 0))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    Console.Clear();
                    Console.Write("ERROR!1!11!1!1!\n");
                }
                else
                {
                    Console.WriteLine(dict[w]);
                    Repeat:
                    Console.Write("Введите exit или закрыть\n");
                    string zakril = Console.ReadLine();
                    switch (zakril)
                    {
                        case "закрыть":
                            Environment.Exit(0);
                            break;
                        case "exit":
                            Environment.Exit(0);
                            break;
                        default:
                            goto Repeat;
                    }
                    Environment.Exit(0);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
            catch(OutOfMemoryException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            Console.WriteLine("Упражнение 6");

            Dead DedVasiliy = new Dead();
            Dead DedMixail = new Dead();
            Dead DedYuriy = new Dead();
            Dead DedIgorb = new Dead();
            Dead DedIvan = new Dead();

            DedVasiliy.imyadeada = "Василий";
            DedMixail.imyadeada = "Михаил";
            DedYuriy.imyadeada = "Юрий";
            DedIgorb.imyadeada = "Игорь";
            DedIvan.imyadeada = "Иван";

            DedVasiliy.sinyak = 0;
            DedMixail.sinyak = 0;
            DedYuriy.sinyak = 0;
            DedIgorb.sinyak = 0;
            DedIvan.sinyak = 0;

            DedVasiliy.cykablyat = "Рукожоп_Негодяй_Чудак-человек".Split('_');
            DedMixail.cykablyat = "Ушлёпок_Профурсетки_Руки в ноги и алга нахуй_Задрот компьютерный".Split('_');
            DedYuriy.cykablyat = "Да нахер они идут_Даниил, убери свою хуйню!_Нацисты!_Пятая колонна!_Не самолёт, а говно летающее".Split('_');
            DedIgorb.cykablyat = " ".Split();
            DedIvan.cykablyat = "Бляди_Тварины ходячие_Тупоголовая старая дрянь_Не кудахтай,курица дохлая_Своими культяпками ты только подрыгать можешь_Безмозглый щенок_Сынок ёбаный".Split('_');
            DedVasiliy.stepvorch = (Dead.Vorch)1;
            DedMixail.stepvorch = (Dead.Vorch)2;
            DedYuriy.stepvorch = (Dead.Vorch)3;
            DedIgorb.stepvorch = 0;
            DedIvan.stepvorch = (Dead.Vorch)4;
            Console.WriteLine($"Дед {DedVasiliy.imyadeada} получил {DedVasiliy.DeadiBabka(DedVasiliy.imyadeada, DedVasiliy.sinyak, DedVasiliy.stepvorch, DedVasiliy.cykablyat)} фингалов");
            Console.WriteLine($"Дед {DedMixail.imyadeada} получил {DedMixail.DeadiBabka(DedMixail.imyadeada, DedMixail.sinyak, DedMixail.stepvorch, DedMixail.cykablyat)} фингал");
            Console.WriteLine($"Дед {DedYuriy.imyadeada} получил {DedYuriy.DeadiBabka(DedYuriy.imyadeada, DedYuriy.sinyak, DedYuriy.stepvorch, DedYuriy.cykablyat)} фингала");
            Console.WriteLine($"Дед {DedIgorb.imyadeada} получил {DedIgorb.DeadiBabka(DedIgorb.imyadeada, DedIgorb.sinyak, DedIgorb.stepvorch, DedIgorb.cykablyat)} фингалов");
            Console.WriteLine($"Дед {DedIvan.imyadeada} получил {DedIvan.DeadiBabka(DedIvan.imyadeada, DedIvan.sinyak, DedIvan.stepvorch, DedIvan.cykablyat)} фингал");
            
            Console.WriteLine("Упражнение 7");
            Console.Write("N = ");

            int len = int.Parse(Console.ReadLine());
            int[] a = new int[len];
            for (int i = 0;i<a.Length;i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", QuickSort(a)));
        }
    }
}

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ab = 2; // ввел все пути между пунктами ( для удобства я их переименовал в буквы )
            int ac = 4;
            int ad = 10;
            int cd = 3;
            int cf = 1;
            int be = 5;
            int bd = 11;
            int de = 8;
            int df = 7;
            int fg = 9;
            int eg = 6;

            int abe = ab + be;
            int ade = ad + de;
            int abde = ab + bd + de;
            int abdf = ab + bd + df;
            int adf = ad + df;
            int acf = ac + cf;
            int acde = ac + cd + de;
            int acdf = ac + cd + df;
            int x1 = abe + eg; // тут уже полные пути до точки G
            int x2 = ade + eg;
            int x3 = abde + eg;
            int x4 = acde + eg;
            int x5 = adf + fg;
            int x6 = acf + fg;
            int x7 = abdf + fg;
            int x8 = acdf + fg;

            int[] num = new int[] { x1, x2, x3, x4, x5, x6, x7, x8 }; // Создаю массив для вычесления кратчайшего пути
            int r = x1;
            for (int i=0; i<num.Length; i++)
            {
                Console.WriteLine("Длинна " + i + " Пути = " + num[i]);
                if (r > num[i])
                    r = num[i];
            }
            Console.WriteLine("Кротчайший путь = " + r);


        }
    }
}
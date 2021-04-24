using System;

namespace ws_HW4
{
    class Program
    {

        static void Main(string[] args)
        {
            int loop;
            loop = int.Parse(Console.ReadLine());
            int[] a = { };
            int[] count = { };
           pascal(loop, count, a);
         
        }
        static void pascal(int loop,int[]count,int[] a)
        {
            int c, i,r;
            for (r = 0; r <= loop; r++)
            {
                a = new int[count.Length +1];
                a[0] = 1;//ค่าแรกในแต่ละแถว
                a[count.Length]=1;//ค่าสุดท้ายแต่ละแถว
                for (c = 1; c < count.Length; c++)//เก็บค่าของคำคอบไว้ในarray
                {
                    a[c] = count[c] + count[c - 1];
                }
                count = a;
                for (i = 0; i < a.Length; i++)//เอาค่าคำตอบมาแสดง
                {
                    Console.Write("{0} ", a[i]);
                }
                Console.WriteLine();
            }
            }
         }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTapLab3_4
{
    internal class Program
    {
        static int[] nhap()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void bai1(int[] a)
        {
            int max1 = 0, max2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max1 < a[i])
                {
                    max1 = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (max1 == a[i])
                {
                    continue;
                }
                else
                {
                    if (max1 > a[i])
                    {
                        max2 = a[i];
                    }
                }
            }
            Console.WriteLine(max2);
        }
        static void bai2()
        {
            long n = long.Parse(Console.ReadLine());
            long[] a = new long[n];
            a[0] = 0;
            a[1] = 1;
            long fibonaci = 0;
            for (long i = 2; i < a.Length; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                fibonaci = a[i];
            }
            Console.WriteLine(fibonaci);
        }
        static void bai2_2()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 2)
            {
                Console.WriteLine("so fibonasi thu {0} la 1", n);
            }
            else
            {// 1 1 2 3 5 
                int f1 = 0, f2 = 1, f3 = 1, cout = 1;
                while (cout < n)
                {
                    f3 = f1 + f2; // f3=1+1=2 f3=3
                    f1 = f2; // 1=1 // f1=2
                    f2 = f3;//f2=2 // f2=3
                    cout++;

                }
                Console.WriteLine(f3);
            }

        }
        static void bai3(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i] * (a[i] % 2);
            }
            Console.WriteLine(sum);
        }
        static void bai4()
        {
            Console.WriteLine("số tên bạn muốn nhập là: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] mangten = new string[size];
            for (int i = 0; i < size; i++) // nhập tên
            {
                Console.WriteLine("nhập tên thứ {0}: ", i + 1);
                mangten[i] = Console.ReadLine();
            }
            string[] ketqua = new string[size];
            for (int i = 0; i < size; i++) // cắt tên
            {
                string[] catten = mangten[i].Split(' ');
                ketqua[i] = catten[catten.Length - 1];
                for (int j = 0; j < catten.Length - 1; j++)
                {
                    ketqua[i] += catten[j][0];
                }
            }
            Array.Sort(ketqua);
            for (int i = 0; i < ketqua.Length - 1; i++) // lọc những tên trúng nhau
            {
                int x = 1;
                for (int j = i + 1; j <= ketqua.Length - 1; j++)
                {
                    if (ketqua[j] == ketqua[i])
                    {
                        ketqua[j] += x;
                        x++;
                    }
                }
            }
            foreach (string item in ketqua) // show kết quả
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            // int[] a = nhap();

            //  bai1( a);
            // bai2_2();
            // bai3(a);
            bai4();
        }
    }
}


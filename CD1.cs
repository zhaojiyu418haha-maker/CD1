using System;

namespace Lesson_1
{
    class Pro
    {
        static bool zhaozhengfu(int[] arr, int index = 0)
        {
            // 基本情况1：数组为空或已检查完所有元素
            if (index >= arr.Length) return true;

            // 基本情况2：发现非正数
            if (arr[index] <= 0) return false;

            // 递归情况：检查下一个元素
            return zhaozhengfu(arr, index + 1);
        }
        static void shuzuhebing(int[] a, int[] b)
        {
            int[] arr = new int[a.Length + b.Length];
            for(int m = 0; m < a.Length; m++)
            {
                arr[m] = a[m];
            }
            for(int n = 0; n < b.Length; n++)
            {
                arr[a.Length + n] = b[n];
            }
            
            for(int t = 0; t < arr.Length; t++)
            {
                for (int x = 0; x < arr.Length - 1 - t; x++) 
                {
                    if (arr[x] > arr[x + 1])
                    {
                        int temp = arr[x];
                        arr[x] = arr[x + 1];
                        arr[x + 1] = temp;
                    }
                }
            }
            for(int u = 0; u < arr.Length; u++)
            {
                Console.WriteLine(arr[u]);
                    
            }
        }




        //static int Fun(int a)
        //{

        //    if (a == 1)
        //    {
        //        return 1;
        //    }

        //    return a * Fun(a - 1);
        //}

        //static int delta(ref int x, ref int y, int delta = 1)
        //{
        //    return x + y + delta;
        //}

        //static void bidaxiao(int x, params int[] arr)
        //{

        //    int index = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > x)
        //        {
        //            index++;
        //        }
        //    }
        //    Console.WriteLine(index);

        //}

        //static void pingfangqiuhe()
        //{
        //    int a = 5;
        //    int b = 0;
        //    for (int n = 1; n <= a; n++)
        //    {
        //        b = b + n * n;
        //    }
        //    Console.WriteLine(b);
        //}



        //static void sanjiaoxing(double a, double b, double c)
        //{
        //    double[] size = { a, b, c };
        //    Array.Sort(size);
        //    a = size[0];
        //    b = size[1];
        //    c = size[2];

        //    if (a + b < c)
        //    {
        //        Console.WriteLine("не возможно создавать треугольник");
        //        return;
        //    }

        //    if (a * a + b * b == c * c)
        //    {
        //        Console.WriteLine("это right");

        //    }
        //    else if (a * a + b * b > c * c)
        //    {
        //        Console.WriteLine("это obtuse");

        //    }
        //    else if (a * a + b * b < c * c)
        //    {
        //        Console.WriteLine("это acute");
        //    }

        //}
        //static void zhaojiou()
        //{
        //    for (int i = 1; i < 5; i++)
        //    {
        //        Console.WriteLine("пишите число");
        //        string about = Console.ReadLine();
        //        int About = int.Parse(about);
        //        if (About % 2 == 0)
        //        {
        //            About = About + 2;
        //        }
        //        else
        //        {
        //            About = About + 1;
        //        }
        //        Console.WriteLine(About);
        //    }
        //}





        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 3 };
            shuzuhebing(arr, arr2);
            zhaozhengfu(arr);


            //Console.WriteLine(Fun(5));


            //    int a = 1;
            //    int b = 2;
            //    Console.WriteLine(delta(ref a, ref b));

            //    bidaxiao(2, 3, 4, 5, 6, 7, 8, 9);
            //    zhaojiou();
            //    sanjiaoxing(2, 2, 6);
            //    pingfangqiuhe();
        }
    }
}

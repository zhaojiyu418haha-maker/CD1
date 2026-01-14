using System;

namespace Lesson_1
{
    class Pro
    {
        static void fun(int a)
        {
            if (a > 10)
            {
                return;
            }
            
            Console.WriteLine(a);
           
            fun(a);
            a++;

        }




        //static int delta(ref int x,ref int y,int delta=1)
        //{
        //    return x + y + delta;
        //}
        
        //static void bidaxiao(int x,params int[] arr)
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
        //    for(int n = 1; n <= a; n++)
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
        //    else if (a * a + b * b < c * c )
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
            fun(0);
            //int a = 1;
            //int b = 2;
            //Console.WriteLine(delta(ref a, ref b));
            
            //bidaxiao(2,3,4,5,6,7,8,9);
            //zhaojiou();
            //sanjiaoxing(2,2,6);
            //pingfangqiuhe();
        }
    }
}

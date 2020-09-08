using System;

namespace _20songuyento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 so nguyen to dau tien la:");
            int index = 0;
            for (int i = 2; i < 200; i++)
            {
                bool check = true;
                for (int count = 2; count <= Math.Sqrt(i); count++)
                {
                    if (i % count == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    index = index + 1;
                    if (index <= 20)
                    {
                        Console.WriteLine(i + "\t");
                    }
                }
            }
        }
    }
}
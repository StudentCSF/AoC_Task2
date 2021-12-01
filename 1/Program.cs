using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();   
            while(true)
            {
                int t = Convert.ToInt32(Console.ReadLine());
                if (t < 0)
                {
                    break;
                }
                list.Add(t);
            }

            int c = 0;
            for (int i = 3; i < list.Count; i++)
            {
                if (list[i] > list[i-3])
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}

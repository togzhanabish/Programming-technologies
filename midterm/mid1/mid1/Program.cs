using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid1
{
    class Program
    {
        public static void f()
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();

            for(int i = 0; i < arr.Length; i++)
            {
                int tmp = int.Parse(arr[i]);
                if (tmp % 2 == 0)
                   Console.Write(tmp + " ");
            }

            
        }
        static void Main(string[] args)
        {
            f();
            Console.ReadKey();
        }
    }
}

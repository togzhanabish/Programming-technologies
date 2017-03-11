using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static bool findprime(int n)
        {
            if (n == 1)
                return false;
            if (n == 2)
                return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\proga\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            string s = sw.ReadLine();
            string[] arr = s.Split();

            int[] numbers = new int[arr.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }
            int mini = int.Parse(arr[0]);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (findprime(numbers[i]) == true)
                {
                    int tmp = int.Parse(arr[i]);
                    if(tmp < mini)
                    {
                        mini = tmp;
                    }
                }                  
            }
            Console.Write(mini);

            sw.Close();
            fs.Close();

            Console.ReadKey();
        }
    }
}
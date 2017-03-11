using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumminimum
{
    class Program
    {
        static void f1()
        {
            FileStream fs = new FileStream(@"c:\proga\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            string s = sw.ReadLine();
            string[] arr = s.Split();

            /*int maxi = int.Parse(arr[0]);
            for(int i = 0; i < arr.Length;i++)
            {
                int tmp = int.Parse(arr[i]);
                if(tmp > maxi)
                {
                    maxi = tmp;
                }
            }*/
            int mini = int.Parse(arr[0]);
            for(int i = 0; i < arr.Length;i++)
            {
                int tmp = int.Parse(arr[i]);
                if(tmp < mini)
                {
                    mini = tmp;
                }
            }

            Console.Write(mini);

            sw.Close();
            fs.Close();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            f1();
        }
    }
}

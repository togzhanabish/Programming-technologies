using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mid3
{
    class Program
    {
        public static ball ball;

        public static int d = 0;

        static void MoveSnake()
        {
            while (!GameOver)
            {
                ball.Draw();

                switch (d)
                {
                    case 0:
                        ball.Move(1, 0);
                        break;
                    case 1:
                        ball.Move(0, 1);
                        break;
                    case 2:
                       ball.Move(-1, 0);
                        break;
                    case 3:
                       ball.Move(0, -1);
                        break;
                }
                Thread.Sleep(100);
            }
        }

        static bool GameOver = false;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);

            while (!GameOver)
            {
                Console.Clear();
                ball.Draw();

       
                switch (d)
                {
                    case 
                   
                }
            }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid3
{
    public class ball
    {
        public ConsoleColor color = ConsoleColor.Yellow;
        public List<Point> body = new List<Point>();
        public char sign = 'O';

        public ball()
        {
            body.Add(new Point(10, 10));
            

        }

        public ball(ConsoleColor color, char sign, List<Point> body)
        {
            this.body = body;
            this.color = color;
            this.sign = sign;
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }
        }

        
        public void Move(int dx, int dy)
        {
            for(int  i = 0; i < body.Count - 1; i++)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x > Console.WindowWidth)
                body.Add(new Point())
            //if (body[0].y > Console.WindowWidth)
                
        }

    }
}

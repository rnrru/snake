using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine horLine1 = new HorizontalLine(0, 78, 0, '+');
            horLine1.Drow();

            VerticalLine verLine1 = new VerticalLine(0, 0, 24, '+');
            verLine1.Drow();

            HorizontalLine horLine2 = new HorizontalLine(0, 78, 24, '+');
            horLine2.Drow();

            VerticalLine verLine2 = new VerticalLine(78, 0, 24, '+');
            verLine2.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();
            
            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            Point p3 = new Point(6, 10, '$');

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);

            foreach (Point i in pointList)
            {
                Console.WriteLine(i);
            }

            List<char> charList = new List<char>();
            charList.Add('$');
            charList.Add(';');
            charList.Add('\'');


            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

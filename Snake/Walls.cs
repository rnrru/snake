using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList; 

        public Walls (int mapWidth, int mapHeight )
        {
            wallList = new List<Figure>();

            HorizontalLine horLine1 = new HorizontalLine(0, mapWidth - 2, 0, '+');
            VerticalLine verLine1 = new VerticalLine(0, 0, mapHeight-1, '+');
            HorizontalLine horLine2 = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine verLine2 = new VerticalLine(mapWidth - 2, 0, mapHeight-1, '+');

            wallList.Add(horLine1);
            wallList.Add(horLine2);
            wallList.Add(verLine1);
            wallList.Add(verLine2);
        }


        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}

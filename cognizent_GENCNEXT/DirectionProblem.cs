using System;

namespace cognizent_GENCNEXT
{
    public class DirectionProblem
    {
        public static float shortestPath(string str)
        {
            int x = 0, y = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char dir = str[i];
                if (dir == 'n' || dir == 'N')
                {
                    y++;
                }
                else if (dir == 's' || dir == 'S')
                {
                    y--;
                }
                else if (dir == 'w' || dir == 'W')
                {
                    x--;
                }
                else
                {
                    x++;
                }


            }
            int x2 = x * x;
            int y2 = y * y;

            return (float)Math.Sqrt(x2 + y2);
        }

        public static void Main(string[] args)
        {

            float val = shortestPath("wneenesennn");
            Console.WriteLine("Shortest path is " + val);
        }
    }
}

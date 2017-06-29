using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            List<Rectangle> euclid = new List<Rectangle>();

            int[] counts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < counts[0]; i++)
            {
                string[] input = Console.ReadLine().Split();

                Rectangle newRect = new Rectangle(input[0], 
                                                  double.Parse(input[1]), double.Parse(input[2]), 
                                                  double.Parse(input[3]), double.Parse(input[4]));
                euclid.Add(newRect);
            }

            for (int i = 0; i < counts[1]; i++)
            {
                string[] rectangular = Console.ReadLine().Split();
                Console.WriteLine(euclid.FirstOrDefault(x => x.ID == rectangular[0])
                 .IsRectIntersect(euclid.FirstOrDefault(x => x.ID == rectangular[1]))
                 .ToString()
                 .ToLower());
            }
        }
    }
}

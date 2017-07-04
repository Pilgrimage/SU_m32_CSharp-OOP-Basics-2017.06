using System;

namespace p15_DrawingTool
{
    public class DrawingTool
    {
        public static void Main()
        {
            Figure figure ;

            string figureType = Console.ReadLine().Trim();
            int sideA = int.Parse(Console.ReadLine());

            if (figureType.ToLower() == "square")
            {
                figure = new Square(sideA);
            }
            else
            {
                int sideB = int.Parse(Console.ReadLine());
                figure = new Rectangle(sideA, sideB);
            }

            //figure.Draw();

            CorDraw.Draw(figure);
        }
    }
}

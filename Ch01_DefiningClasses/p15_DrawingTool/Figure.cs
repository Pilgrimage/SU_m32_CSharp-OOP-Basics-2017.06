namespace p15_DrawingTool
{
    using System;

    public abstract class Figure
    {
        protected int sideA;
        protected int sideB;

        public Figure(int sideA)
        {
            this.sideA = sideA;
            this.sideB = sideA;
        }

        public void Draw()
        {
            string borderRow = "|" + new string('-', this.sideA) + "|";

            Console.WriteLine(borderRow);
            for (int row = 0; row < this.sideB - 2; row++)
            {
                Console.WriteLine("|" + new string(' ', this.sideA) + "|");
            }

            Console.WriteLine(borderRow);
        }







    }
}

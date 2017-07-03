namespace p02_ClassBoxDataValidation
{
    using System;
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }


        public string GetSurfaceArea()
        {
            double result = 2 * (this.length * this.width + this.length * this.height + this.width * this.height);
            return $"Surface Area - {result:f2}";
        }

        public string GetLateralSurfaceArea()
        {
            double result = 2 * (this.length * this.height + this.width * this.height);
            return $"Lateral Surface Area - {result:f2}";
        }
        public string GetVolume()
        {
            double result = this.length * this.width * this.height;
            return $"Volume - {result:f2}";
        }

    }
}

namespace p01_ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string GetSurfaceArea()
        {
            double result = 2* (length*width + length*height + width*height);
            return $"Surface Area - {result:f2}";
        }

        public string GetLateralSurfaceArea()
        {
            double result = 2 * (length * height + width * height);
            return $"Lateral Surface Area - {result:f2}";
        }
        public string GetVolume()
        {
            double result = length * width * height;
            return $"Volume - {result:f2}";
        }

    }
}

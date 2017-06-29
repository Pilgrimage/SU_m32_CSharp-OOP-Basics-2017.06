namespace p09_RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topLeftX;
        private double topLeftY;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double TopLeftX
        {
            get { return this.topLeftX; }
            set { this.topLeftX = value; }
        }

        public double TopLeftY
        {
            get { return this.topLeftY; }
            set { this.topLeftY = value; }
        }

        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
        }

        public bool IsRectIntersect(Rectangle rect)
        {

            if ((this.TopLeftX + this.Width) < rect.topLeftX ||
                (rect.topLeftX + rect.Width) < this.TopLeftX ||
                (this.TopLeftY + this.Height) < rect.TopLeftY ||
                (rect.TopLeftY + rect.Height) < this.TopLeftY)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

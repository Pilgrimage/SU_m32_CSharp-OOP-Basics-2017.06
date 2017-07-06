public class Rectangle : Shape
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public double SideA
    {
        get { return this.sideA; }
        set { this.sideA = value; }
    }

    public double SideB
    {
        get { return this.sideB; }
        set { this.sideB = value; }
    }

    public override double CalculatePerimeter()
    {
        return 2 * (SideA + sideB);
    }

    public override double CalculateArea()
    {
        return sideA * SideB;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }

}


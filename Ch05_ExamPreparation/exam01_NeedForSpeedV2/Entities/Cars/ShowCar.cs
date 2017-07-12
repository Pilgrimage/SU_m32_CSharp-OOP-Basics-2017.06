using System.Text;

public class ShowCar : Car
{
    private int starts;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension,
        int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;

    }

    public int Stars
    {
        get { return this.starts; }
        set { this.starts = value; }
    }

    public override void TuneUp(int tuneIndex, string addOn)
    {
        base.TuneUp(tuneIndex, addOn);
        this.Stars += tuneIndex;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{this.Stars} *");

        return sb.ToString().Trim();
    }
}



class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
        this.EnergyOutput = base.EnergyOutput * 1.5;
    }

}

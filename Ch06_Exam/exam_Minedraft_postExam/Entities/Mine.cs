public abstract class Mine
{
    private string id;

    protected Mine(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }
}

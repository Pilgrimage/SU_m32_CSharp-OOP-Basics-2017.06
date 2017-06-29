public class Person
{
    private readonly string firstName;
    private readonly string lastName;
    private readonly int age;

    public string FirstName
    {
        get { return this.firstName; }
    }

    public string LastName
    {
        get { return this.lastName; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
    }
}


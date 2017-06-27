using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public List<BankAccount> Accounts { get; set; }

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.name = name;
        this.age = age;
        this.accounts = accounts;
    }

    //public Person(string name, int age) : this(name, age, new List<BankAccount>())
    //{
    //    this.Name = name;
    //    this.Age = age;
    //    this.Accounts = new List<BankAccount>();
    //}

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.accounts = new List<BankAccount>();
    }


    public double GetBalance()
    {
        return this.accounts.Sum(x => x.Balance);
    }
}

using System;
using System.Collections.Generic;

public class labAll
{
    public static void Main()
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int id = int.Parse(command[1]);

            switch (command[0])
            {
                case "Create":
                    Create(command, accounts);
                    break;

                case "Deposit":
                    Deposit(command, accounts);
                    break;

                case "Withdraw":
                    Withdraw(command, accounts);
                    break;
                case "Print":
                    Print(command, accounts);
                    break;
            }
        }


    }


    private static void Create(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount newAccount = new BankAccount() { ID = id, Balance = 0 };
            accounts.Add(id, newAccount);
        }
    }

    private static void Deposit(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(double.Parse(command[2]));
        }
    }

    private static void Withdraw(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);
        double amount = double.Parse(command[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Withdraw(amount);
        }
    }

    private static void Print(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine($"Account ID{accounts[id].ID}, balance {accounts[id].Balance:f2}");
        }
    }

}

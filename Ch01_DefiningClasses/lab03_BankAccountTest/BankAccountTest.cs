using System;
using System.Collections.Generic;

public class BankAccountTest
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
                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        accounts.Add(id, new BankAccount() { ID = id, Balance = 0 });
                    }
                    break;

                case "Deposit":
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        accounts[id].Deposit(double.Parse(command[2]));
                    }
                    break;

                case "Withdraw":
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

                    break;
                case "Print":
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine(accounts[id].ToString());
                    }
                    break;
            }
        }

    }
}


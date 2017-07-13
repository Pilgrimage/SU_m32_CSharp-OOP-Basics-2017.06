using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }


    public void Run()
    {
        while (this.isRunning)
        {
            string inCommand = Console.ReadLine();
            List<string> commParams = inCommand.Split(' ').ToList();
            this.DistributeCommand(commParams);
        }
    }


    private void DistributeCommand(List<string> commParams)
    {
        string command = commParams[0];
        commParams.Remove(command);

        switch (command)
        {
            case "Bender":
                this.nationsBuilder.AssignBender(commParams);
                break;
            case "Monument":
                this.nationsBuilder.AssignMonument(commParams);
                break;

            case "Status":
                string status = this.nationsBuilder.GetStatus(commParams[0]);
                this.OutputWiter(status);
                break;

            case "War":
                this.nationsBuilder.IssueWar(commParams[0]);
                break;

            case "Quit":
                string record = this.nationsBuilder.GetWarsRecord();
                this.OutputWiter(record);
                this.isRunning = false;
                break;
        }

    }


    private void OutputWiter(string status)
    {
        Console.WriteLine(status);
    }
}

